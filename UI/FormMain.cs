﻿using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //if (this.Tag.ToString()=="1") {


            //    managerMenu.Visible = false;
            //        }
        }

        private void quitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
