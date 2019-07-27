using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
        private void buttonX1_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo();
            mi.MName = textBoxX1.Text;
            mi.MPwd = textBoxX2.Text;
            ManagerInfoBLL bll = new ManagerInfoBLL();
            if (bll.Login(mi)) {
                DialogResult res=  MessageBox.Show("登录成功！","提示",MessageBoxButtons.OK);
                if (res==DialogResult.OK) {
                    FormMain main = new FormMain();
                    main.Show();
                 
                    this.Visible = false;


                }

            }else
            {
                MessageBox.Show("登录失败1！");
            }
           ;
        }
    }
}
