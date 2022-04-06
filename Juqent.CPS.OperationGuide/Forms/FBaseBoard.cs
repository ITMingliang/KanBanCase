using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Juqent.CPS.OperationGuide
{
    public partial class FBaseBoard : Form
    {
        private bool IsHideToolBar = true;

        public FBaseBoard()
        {
            InitializeComponent();
        }

        private void HideToolBar()
        {
            if (IsHideToolBar)
            {
                btnHide.Symbol = "";
                barTool.Size = new Size(55, 25);
                barTool.Location = new Point(this.Size.Width - barTool.Size.Width, this.Size.Height - barTool.Size.Height);
            }
            else
            {
                btnHide.Symbol = "";
                barTool.Size = new Size(400, 25);
                barTool.Location = new Point(this.Size.Width - barTool.Size.Width, this.Size.Height - barTool.Size.Height);
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            IsHideToolBar = !IsHideToolBar;
            HideToolBar();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FBaseBoard_Resize(object sender, EventArgs e)
        {
            HideToolBar();
        }

    }
}
