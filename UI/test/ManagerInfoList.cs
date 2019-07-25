using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Configuration;
using Model;
using BLL;

namespace UI.test
{
    public partial class ManagerInfoList : Form
    {
        public ManagerInfoList()
        {
            InitializeComponent();
        }
        ManagerInfoBLL miBll = new ManagerInfoBLL();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void ManagerInfoList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void gvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                switch (e.Value.ToString())
                {
                    case "1":
                        e.Value = "经理";
                        break;
                    case "0":
                        e.Value = "店员";
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "添加")
            {
                ManagerInfo InsertData = new ManagerInfo()
                {
                    MName = textBox3.Text.Trim(),
                    MPwd = textBox2.Text.Trim(),
                    MType = radioButton1.Checked ? 1 : 0
                };
                if (miBll.Add(InsertData))
                {

                    LoadList();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }

            }
            else
            {
                ManagerInfo ModifierData = new ManagerInfo()
                {
                    MName = textBox3.Text.Trim(),
                    MPwd = textBox2.Text.Trim(),
                    MType = radioButton1.Checked ? 1 : 0,
                    Mid =Convert.ToInt32( textBox1.Text.Trim())
                };

                if (miBll.Modifier(ModifierData)) {

                    MessageBox.Show("修改成功！");
                    LoadList();

                };




            }
            

        }
        private void LoadList()
        {
            List<ManagerInfo> miblllist = miBll.GetList();
            gvList.DataSource = miblllist;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var rows = gvList.SelectedRows;
            if (rows.Count > 0)
            {
                DialogResult result = MessageBox.Show("确定要删除吗？", "提示",MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    int id = Convert.ToInt32(rows[0].Cells[0].Value);
                    if (miBll.Remove(id)) {
                        LoadList();

                     } else
                    {
                        MessageBox.Show("请稍后重试！");
                    }

                }
            }
            else
            {
                MessageBox.Show("请选择！");
            }
        }

        private void gvList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void gvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows =  gvList.Rows[e.RowIndex];
            textBox1.Text = rows.Cells[0].Value.ToString();
            textBox3.Text = rows.Cells[1].Value.ToString();
            textBox2.Text = "*****";
            if (rows.Cells[2].Value.ToString()=="1") {

                radioButton1.Checked = true;

            }
            else
            {
                radioButton2.Checked = true;
            }
            button2.Text = "修改";
        }
    }
}
