namespace Juqent.CPS.OperationGuide
{
    partial class FBaseBoard
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
        public void InitializeComponent()
        {
            this.gpMain = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.barTool = new DevComponents.DotNetBar.Bar();
            this.btnHide = new DevComponents.DotNetBar.ButtonItem();
            this.btnQuit = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barTool)).BeginInit();
            this.SuspendLayout();
            // 
            // gpMain
            // 
            this.gpMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.gpMain.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gpMain.DisabledBackColor = System.Drawing.Color.Empty;
            this.gpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpMain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.gpMain.Location = new System.Drawing.Point(0, 0);
            this.gpMain.Name = "gpMain";
            this.gpMain.Size = new System.Drawing.Size(1348, 721);
            // 
            // 
            // 
            this.gpMain.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gpMain.Style.BackColorGradientAngle = 90;
            this.gpMain.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gpMain.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMain.Style.BorderBottomWidth = 1;
            this.gpMain.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gpMain.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMain.Style.BorderLeftWidth = 1;
            this.gpMain.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMain.Style.BorderRightWidth = 1;
            this.gpMain.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gpMain.Style.BorderTopWidth = 1;
            this.gpMain.Style.CornerDiameter = 4;
            this.gpMain.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gpMain.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gpMain.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gpMain.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gpMain.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gpMain.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gpMain.TabIndex = 0;
            this.gpMain.Text = "BaseBoard";
            // 
            // barTool
            // 
            this.barTool.AntiAlias = true;
            this.barTool.AutoHide = true;
            this.barTool.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.barTool.IsMaximized = false;
            this.barTool.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHide,
            this.btnQuit});
            this.barTool.Location = new System.Drawing.Point(768, 503);
            this.barTool.Name = "barTool";
            this.barTool.Size = new System.Drawing.Size(538, 41);
            this.barTool.Stretch = true;
            this.barTool.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.barTool.TabIndex = 0;
            this.barTool.TabStop = false;
            this.barTool.Text = "工具条";
            // 
            // btnHide
            // 
            this.btnHide.Name = "btnHide";
            this.btnHide.Symbol = "";
            this.btnHide.Text = ">>";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Symbol = "";
            this.btnQuit.SymbolColor = System.Drawing.Color.Red;
            this.btnQuit.Text = "退出";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FBaseBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.barTool);
            this.Controls.Add(this.gpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FBaseBoard";
            this.Text = "FBaseBoard";
            this.Resize += new System.EventHandler(this.FBaseBoard_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.barTool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.Controls.GroupPanel gpMain;
        private DevComponents.DotNetBar.ButtonItem btnHide;
        private DevComponents.DotNetBar.ButtonItem btnQuit;
        protected DevComponents.DotNetBar.Bar barTool;
    }
}