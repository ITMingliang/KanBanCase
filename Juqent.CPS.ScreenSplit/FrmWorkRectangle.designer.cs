namespace Juqent.CPS.ScreenSplit
{
    partial class FrmWorkRectangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorkRectangle));
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            this.SuspendLayout();
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(0, 3);
            this.pic1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(380, 212);
            this.pic1.TabIndex = 0;
            this.pic1.TabStop = false;
            this.pic1.Tag = "";
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(380, 3);
            this.pic2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(380, 212);
            this.pic2.TabIndex = 1;
            this.pic2.TabStop = false;
            this.pic2.Tag = "";
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(760, 3);
            this.pic3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(380, 212);
            this.pic3.TabIndex = 2;
            this.pic3.TabStop = false;
            this.pic3.Tag = "";
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(1140, 3);
            this.pic4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(380, 212);
            this.pic4.TabIndex = 3;
            this.pic4.TabStop = false;
            this.pic4.Tag = "";
            this.pic4.Click += new System.EventHandler(this.pic4_Click);
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(1520, 3);
            this.pic5.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(380, 212);
            this.pic5.TabIndex = 4;
            this.pic5.TabStop = false;
            this.pic5.Click += new System.EventHandler(this.pic5_Click);
            // 
            // FrmWorkRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1902, 216);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWorkRectangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择投放区域";
            this.Load += new System.EventHandler(this.FrmWorkRectangle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;


    }
}