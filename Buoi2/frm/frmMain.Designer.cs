namespace Buoi2.frm
{
    partial class frmMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.buổi2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai2TinSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buổi2ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1335, 30);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // buổi2ToolStripMenuItem
            // 
            this.buổi2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bai1ToolStripMenuItem,
            this.Bai2TinSVToolStripMenuItem});
            this.buổi2ToolStripMenuItem.Name = "buổi2ToolStripMenuItem";
            this.buổi2ToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.buổi2ToolStripMenuItem.Text = "Buổi 2";
            // 
            // Bai1ToolStripMenuItem
            // 
            this.Bai1ToolStripMenuItem.Image = global::Buoi2.Properties.Resources._default;
            this.Bai1ToolStripMenuItem.Name = "Bai1ToolStripMenuItem";
            this.Bai1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Bai1ToolStripMenuItem.Text = "Bài 1 - Tính 2 số";
            this.Bai1ToolStripMenuItem.Click += new System.EventHandler(this.Bai1ToolStripMenuItem_Click);
            // 
            // Bai2TinSVToolStripMenuItem
            // 
            this.Bai2TinSVToolStripMenuItem.Name = "Bai2TinSVToolStripMenuItem";
            this.Bai2TinSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.Bai2TinSVToolStripMenuItem.Text = "Bái 2 - Thông tin SV";
            this.Bai2TinSVToolStripMenuItem.Click += new System.EventHandler(this.Bai2TinSVToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 493);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem buổi2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bai1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bai2TinSVToolStripMenuItem;
    }
}