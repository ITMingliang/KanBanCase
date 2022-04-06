using System.Drawing;

namespace Juqent.CPS.OperationGuide
{
    partial class FConfig
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.tbEquipmentCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelEquipmentCode = new DevComponents.DotNetBar.LabelX();
            this.tbWorkCenter = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lableWorkCenture = new DevComponents.DotNetBar.LabelX();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnSet = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.title = new DevComponents.DotNetBar.LabelX();
            this.tbFileSavePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelFileSavePath = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.centerPanel);
            this.groupPanel1.Controls.Add(this.btnPanel);
            this.groupPanel1.Controls.Add(this.title);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(506, 278);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // centerPanel
            // 
            this.centerPanel.BackColor = System.Drawing.Color.Transparent;
            this.centerPanel.Controls.Add(this.tbFileSavePath);
            this.centerPanel.Controls.Add(this.labelFileSavePath);
            this.centerPanel.Controls.Add(this.tbEquipmentCode);
            this.centerPanel.Controls.Add(this.labelEquipmentCode);
            this.centerPanel.Controls.Add(this.tbWorkCenter);
            this.centerPanel.Controls.Add(this.lableWorkCenture);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 37);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(500, 194);
            this.centerPanel.TabIndex = 10;
            // 
            // tbEquipmentCode
            // 
            // 
            // 
            // 
            this.tbEquipmentCode.Border.Class = "TextBoxBorder";
            this.tbEquipmentCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbEquipmentCode.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEquipmentCode.Location = new System.Drawing.Point(153, 116);
            this.tbEquipmentCode.Name = "tbEquipmentCode";
            this.tbEquipmentCode.PreventEnterBeep = true;
            this.tbEquipmentCode.Size = new System.Drawing.Size(338, 28);
            this.tbEquipmentCode.TabIndex = 7;
            // 
            // labelEquipmentCode
            // 
            this.labelEquipmentCode.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelEquipmentCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelEquipmentCode.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEquipmentCode.Location = new System.Drawing.Point(-3, 116);
            this.labelEquipmentCode.Name = "labelEquipmentCode";
            this.labelEquipmentCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEquipmentCode.Size = new System.Drawing.Size(150, 37);
            this.labelEquipmentCode.TabIndex = 6;
            this.labelEquipmentCode.Text = "设备编号:";
            this.labelEquipmentCode.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbWorkCenter
            // 
            // 
            // 
            // 
            this.tbWorkCenter.Border.Class = "TextBoxBorder";
            this.tbWorkCenter.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbWorkCenter.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWorkCenter.Location = new System.Drawing.Point(153, 65);
            this.tbWorkCenter.Name = "tbWorkCenter";
            this.tbWorkCenter.PreventEnterBeep = true;
            this.tbWorkCenter.Size = new System.Drawing.Size(338, 28);
            this.tbWorkCenter.TabIndex = 5;
            // 
            // lableWorkCenture
            // 
            this.lableWorkCenture.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lableWorkCenture.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lableWorkCenture.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lableWorkCenture.Location = new System.Drawing.Point(-4, 65);
            this.lableWorkCenture.Name = "lableWorkCenture";
            this.lableWorkCenture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lableWorkCenture.Size = new System.Drawing.Size(151, 37);
            this.lableWorkCenture.TabIndex = 4;
            this.lableWorkCenture.Text = "工作中心编号:";
            this.lableWorkCenture.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnPanel
            // 
            this.btnPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnPanel.Controls.Add(this.btnSet);
            this.btnPanel.Controls.Add(this.btnClose);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 231);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(500, 41);
            this.btnPanel.TabIndex = 9;
            // 
            // btnSet
            // 
            this.btnSet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSet.BackColor = System.Drawing.SystemColors.Control;
            this.btnSet.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(109, 5);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(80, 30);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "设置";
            this.btnSet.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClose.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(309, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 30);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.title.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.title.Size = new System.Drawing.Size(500, 37);
            this.title.TabIndex = 4;
            this.title.Text = "系统配置";
            this.title.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbFileSavePath
            // 
            // 
            // 
            // 
            this.tbFileSavePath.Border.Class = "TextBoxBorder";
            this.tbFileSavePath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbFileSavePath.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFileSavePath.Location = new System.Drawing.Point(153, 14);
            this.tbFileSavePath.Name = "tbFileSavePath";
            this.tbFileSavePath.PreventEnterBeep = true;
            this.tbFileSavePath.Size = new System.Drawing.Size(338, 28);
            this.tbFileSavePath.TabIndex = 9;
            // 
            // labelFileSavePath
            // 
            this.labelFileSavePath.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelFileSavePath.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelFileSavePath.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFileSavePath.Location = new System.Drawing.Point(-4, 14);
            this.labelFileSavePath.Name = "labelFileSavePath";
            this.labelFileSavePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFileSavePath.Size = new System.Drawing.Size(151, 37);
            this.labelFileSavePath.TabIndex = 8;
            this.labelFileSavePath.Text = "文件保存路径:";
            this.labelFileSavePath.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 278);
            this.Controls.Add(this.groupPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FConfig_Load);
            this.groupPanel1.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSet;
        private DevComponents.DotNetBar.LabelX title;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Panel centerPanel;
        private DevComponents.DotNetBar.Controls.TextBoxX tbWorkCenter;
        private DevComponents.DotNetBar.LabelX lableWorkCenture;
        private DevComponents.DotNetBar.Controls.TextBoxX tbEquipmentCode;
        private DevComponents.DotNetBar.LabelX labelEquipmentCode;
        private DevComponents.DotNetBar.Controls.TextBoxX tbFileSavePath;
        private DevComponents.DotNetBar.LabelX labelFileSavePath;
    }
}

