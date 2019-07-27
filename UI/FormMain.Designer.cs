namespace UI
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.memberMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dishMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tableMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 30);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerMenu,
            this.memberMenu,
            this.dishMenu,
            this.tableMenu,
            this.orderMenu,
            this.quitMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerMenu
            // 
            this.managerMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.managerMenu.Image = ((System.Drawing.Image)(resources.GetObject("managerMenu.Image")));
            this.managerMenu.Name = "managerMenu";
            this.managerMenu.Size = new System.Drawing.Size(44, 34);
            this.managerMenu.Text = "manager";
            // 
            // memberMenu
            // 
            this.memberMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memberMenu.Image = ((System.Drawing.Image)(resources.GetObject("memberMenu.Image")));
            this.memberMenu.Name = "memberMenu";
            this.memberMenu.Size = new System.Drawing.Size(44, 34);
            this.memberMenu.Text = "member";
            // 
            // dishMenu
            // 
            this.dishMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dishMenu.Image = ((System.Drawing.Image)(resources.GetObject("dishMenu.Image")));
            this.dishMenu.Name = "dishMenu";
            this.dishMenu.Size = new System.Drawing.Size(44, 34);
            this.dishMenu.Text = "dish";
            // 
            // tableMenu
            // 
            this.tableMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableMenu.Image = ((System.Drawing.Image)(resources.GetObject("tableMenu.Image")));
            this.tableMenu.Name = "tableMenu";
            this.tableMenu.Size = new System.Drawing.Size(44, 34);
            this.tableMenu.Text = "table";
            // 
            // orderMenu
            // 
            this.orderMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderMenu.Image = ((System.Drawing.Image)(resources.GetObject("orderMenu.Image")));
            this.orderMenu.Name = "orderMenu";
            this.orderMenu.Size = new System.Drawing.Size(44, 34);
            this.orderMenu.Text = "order";
            // 
            // quitMenu
            // 
            this.quitMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quitMenu.Image = ((System.Drawing.Image)(resources.GetObject("quitMenu.Image")));
            this.quitMenu.Name = "quitMenu";
            this.quitMenu.Size = new System.Drawing.Size(44, 34);
            this.quitMenu.Text = "quit";
            this.quitMenu.Click += new System.EventHandler(this.quitMenu_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 383);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managerMenu;
        private System.Windows.Forms.ToolStripMenuItem memberMenu;
        private System.Windows.Forms.ToolStripMenuItem dishMenu;
        private System.Windows.Forms.ToolStripMenuItem tableMenu;
        private System.Windows.Forms.ToolStripMenuItem orderMenu;
        private System.Windows.Forms.ToolStripMenuItem quitMenu;
    }
}