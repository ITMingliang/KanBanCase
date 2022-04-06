namespace Juqent.CPS.OperationGuide
{
    partial class FCfig
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.tbWorkCenter = new System.Windows.Forms.TextBox();
            this.lableWorkCenture = new System.Windows.Forms.Label();
            this.tbFileSavePath = new System.Windows.Forms.TextBox();
            this.labelFileSavePath = new System.Windows.Forms.Label();
            this.tbEquipmentCode = new System.Windows.Forms.TextBox();
            this.labelEquipmentCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(284, 198);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(106, 198);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 30);
            this.btnSet.TabIndex = 10;
            this.btnSet.Text = "保存";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // tbWorkCenter
            // 
            this.tbWorkCenter.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWorkCenter.Location = new System.Drawing.Point(141, 74);
            this.tbWorkCenter.Name = "tbWorkCenter";
            this.tbWorkCenter.Size = new System.Drawing.Size(297, 28);
            this.tbWorkCenter.TabIndex = 9;
            // 
            // lableWorkCenture
            // 
            this.lableWorkCenture.AutoSize = true;
            this.lableWorkCenture.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lableWorkCenture.Location = new System.Drawing.Point(5, 80);
            this.lableWorkCenture.Name = "lableWorkCenture";
            this.lableWorkCenture.Size = new System.Drawing.Size(133, 19);
            this.lableWorkCenture.TabIndex = 8;
            this.lableWorkCenture.Text = "工作中心编号:";
            // 
            // tbFileSavePath
            // 
            this.tbFileSavePath.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFileSavePath.Location = new System.Drawing.Point(141, 20);
            this.tbFileSavePath.Name = "tbFileSavePath";
            this.tbFileSavePath.Size = new System.Drawing.Size(297, 28);
            this.tbFileSavePath.TabIndex = 7;
            // 
            // labelFileSavePath
            // 
            this.labelFileSavePath.AutoSize = true;
            this.labelFileSavePath.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFileSavePath.Location = new System.Drawing.Point(3, 25);
            this.labelFileSavePath.Name = "labelFileSavePath";
            this.labelFileSavePath.Size = new System.Drawing.Size(133, 19);
            this.labelFileSavePath.TabIndex = 6;
            this.labelFileSavePath.Text = "文件保存路径:";
            // 
            // tbEquipmentCode
            // 
            this.tbEquipmentCode.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEquipmentCode.Location = new System.Drawing.Point(141, 127);
            this.tbEquipmentCode.Name = "tbEquipmentCode";
            this.tbEquipmentCode.Size = new System.Drawing.Size(297, 28);
            this.tbEquipmentCode.TabIndex = 13;
            // 
            // labelEquipmentCode
            // 
            this.labelEquipmentCode.AutoSize = true;
            this.labelEquipmentCode.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelEquipmentCode.Location = new System.Drawing.Point(42, 132);
            this.labelEquipmentCode.Name = "labelEquipmentCode";
            this.labelEquipmentCode.Size = new System.Drawing.Size(95, 19);
            this.labelEquipmentCode.TabIndex = 12;
            this.labelEquipmentCode.Text = "设备编号:";
            // 
            // FCfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 236);
            this.Controls.Add(this.tbEquipmentCode);
            this.Controls.Add(this.labelEquipmentCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.tbWorkCenter);
            this.Controls.Add(this.lableWorkCenture);
            this.Controls.Add(this.tbFileSavePath);
            this.Controls.Add(this.labelFileSavePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FCfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统配置";
            this.Load += new System.EventHandler(this.FCfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox tbWorkCenter;
        private System.Windows.Forms.Label lableWorkCenture;
        private System.Windows.Forms.TextBox tbFileSavePath;
        private System.Windows.Forms.Label labelFileSavePath;
        private System.Windows.Forms.TextBox tbEquipmentCode;
        private System.Windows.Forms.Label labelEquipmentCode;
    }
}