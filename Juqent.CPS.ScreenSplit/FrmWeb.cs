using Juqent.CPS.WebApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Juqent.CPS.ScreenSplit
{
    public partial class FrmWeb : Form
    {
        public delegate void CompOneHandle(int a);
        //public event CompOneHandle CompOneEvent;
        private PageInfoDto _pageInfo;

        public FrmWeb(PageInfoDto pageInfo)
        {
            InitializeComponent();
            _pageInfo = pageInfo;
            this.Text = _pageInfo.DisplayText;
        }

        private void tsmiTouHuang_Click(object sender, EventArgs e)
        {
            touHuang();
        }

        private void FrmWeb_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.webMain.Url = new Uri(_pageInfo.Url);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWeb_KeyDown(object sender, KeyEventArgs e)
        {
            setShortcuts(e.KeyCode);
        }

        /// <summary>
        /// 设置快捷键
        /// </summary>
        /// <param name="e"></param>
        private void setShortcuts(Keys k)
        {
            switch (k)
            {
                case Keys.F6:
                    Screen scn = ScreenHelper.GetPrimaryScreen();
                    MouseHelper.SetMouseAtCenterScreen(scn);
                    break;
                case Keys.F8:
                    touHuang();
                    break;
            }
        }

        /// <summary>
        /// 投放
        /// </summary>
        private void touHuang()
        {
            FrmWorkRectangle rec = new FrmWorkRectangle(new FrmWeb(_pageInfo));
            rec.Show();
            this.Close();
        }

        private void webMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            setShortcuts(e.KeyCode);
        }
    }
}
