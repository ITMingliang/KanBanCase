using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Juqent.CPS.ScreenSplit
{
    public partial class FrmWorkRectangle : Form
    {
        public FrmWorkRectangle()
        {
            InitializeComponent();
        }

        private Form frm;
        public FrmWorkRectangle(Form frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void FrmWorkRectangle_Load(object sender, EventArgs e)
        {
            Screen[] sc = Screen.AllScreens;
            if (sc.Length > 0)
            {
                Image img = null;
                Bitmap b = null;
                int index = -1;
                for (int i = 0; i < sc.Length; i++)
                {
                    if (sc[i].Primary)
                    {
                        continue;
                    }

                    #region 将图像放到指定区域

                    index++;
                    b = ScreenHelper.CopyPrimaryScreen(sc[i].Bounds);
                    img = ScreenHelper.ResizeImage(b, new Size(pic1.Width, pic1.Height));
                    switch (index)
                    {
                        case 0:
                            this.pic1.Image = img;
                            this.pic1.Tag = i;
                            break;
                        case 1:
                            this.pic2.Image = img;
                            this.pic2.Tag = i;
                            break;
                        case 2:
                            this.pic3.Image = img;
                            this.pic3.Tag = i;
                            break;
                        case 3:
                            this.pic4.Image = img;
                            this.pic4.Tag = i;
                            break;
                        case 4:
                            this.pic5.Image = img;
                            this.pic5.Tag = i;
                            break;
                    }

                    #endregion
                }
            }
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("确定投放窗口【{0}】吗？", this.frm.Text), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ScreenHelper.SetScreen(this.frm, Convert.ToInt32(this.pic1.Tag));
                this.frm.Show();
                this.Close();
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("确定投放窗口【{0}】吗？", this.frm.Text), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ScreenHelper.SetScreen(this.frm, Convert.ToInt32(this.pic2.Tag));
                this.frm.Show();
                this.Close();
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("确定投放窗口【{0}】吗？", this.frm.Text), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ScreenHelper.SetScreen(this.frm, Convert.ToInt32(this.pic3.Tag));
                this.frm.Show();
                this.Close();
            }
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("确定投放窗口【{0}】吗？", this.frm.Text), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ScreenHelper.SetScreen(this.frm, Convert.ToInt32(this.pic4.Tag));
                this.frm.Show();
                this.Close();
            }
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(string.Format("确定投放窗口【{0}】吗？", this.frm.Text), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ScreenHelper.SetScreen(this.frm, Convert.ToInt32(this.pic5.Tag));
                this.frm.Show();
                this.Close();
            }
        }        
    }
}
