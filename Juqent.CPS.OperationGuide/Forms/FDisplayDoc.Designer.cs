namespace Juqent.CPS.OperationGuide
{
    partial class FDisplayDoc
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.btnSOP = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.btnSIP = new DevComponents.DotNetBar.ButtonItem();
            this.btnConfig = new DevComponents.DotNetBar.ButtonItem();
            this.gpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpMain
            // 
            this.gpMain.Controls.Add(this.bar1);
            this.gpMain.Size = new System.Drawing.Size(1024, 768);
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
            this.gpMain.Text = "";
            // 
            // barTool
            // 
            this.barTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barTool.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnConfig});
            this.barTool.Location = new System.Drawing.Point(0, 727);
            this.barTool.Size = new System.Drawing.Size(1024, 41);
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar1.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bar1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSOP,
            this.buttonItem2,
            this.btnSIP});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(1018, 35);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 5;
            this.bar1.TabStop = false;
            this.bar1.Text = "bar1";
            // 
            // btnSOP
            // 
            this.btnSOP.Name = "btnSOP";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "作业指导书";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // btnSIP
            // 
            this.btnSIP.Name = "btnSIP";
            this.btnSIP.Text = "检查基准书";
            this.btnSIP.Click += new System.EventHandler(this.btnSIP_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Symbol = "";
            this.btnConfig.Text = "配置";
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // FDisplayDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FDisplayDoc";
            this.Text = "作业指导书";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FDisplayDoc_Load);
            this.gpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ButtonItem btnSOP;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem btnSIP;
        private DevComponents.DotNetBar.ButtonItem btnConfig;
    }
}

