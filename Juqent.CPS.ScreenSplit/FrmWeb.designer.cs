namespace Juqent.CPS.ScreenSplit
{
    partial class FrmWeb
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWeb));
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTouHuang = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Label();
            this.webMain = new System.Windows.Forms.WebBrowser();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMain
            // 
            this.cmsMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTouHuang});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(161, 34);
            // 
            // tsmiTouHuang
            // 
            this.tsmiTouHuang.Name = "tsmiTouHuang";
            this.tsmiTouHuang.Size = new System.Drawing.Size(160, 30);
            this.tsmiTouHuang.Text = "投放窗口";
            this.tsmiTouHuang.Click += new System.EventHandler(this.tsmiTouHuang_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1822, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 44);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // webMain
            // 
            this.webMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webMain.Location = new System.Drawing.Point(0, 0);
            this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMain.Name = "webMain";
            this.webMain.Size = new System.Drawing.Size(1920, 1080);
            this.webMain.TabIndex = 11;
            this.webMain.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.webMain_PreviewKeyDown);
            // 
            // FrmWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Juqent.CPS.ScreenSplit.Properties.Resources._00首页_01背景;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ContextMenuStrip = this.cmsMain;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.webMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmWeb_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmWeb_KeyDown);
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiTouHuang;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.WebBrowser webMain;
    }
}