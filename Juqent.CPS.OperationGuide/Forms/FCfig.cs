using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juqent.CPS.OperationGuide
{
    public partial class FCfig : Form
    {
        public FCfig()
        {
            InitializeComponent();
        }

        private void FCfig_Load(object sender, EventArgs e)
        {
            this.tbFileSavePath.Text = Common.GetConfigValue(Common._SavePath_key);
            this.tbWorkCenter.Text = Common.GetConfigValue(Common._WorkCenterCode_key);
            this.tbEquipmentCode.Text = Common.GetConfigValue(Common._EquipmentCode_key);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            string fileSavePath = this.tbFileSavePath.Text.Trim();
            string workCenter = this.tbWorkCenter.Text.Trim();
            string equipmentCode = this.tbEquipmentCode.Text.Trim();

            if (string.IsNullOrEmpty(fileSavePath) ||
                string.IsNullOrEmpty(workCenter) ||
                string.IsNullOrEmpty(equipmentCode))
            {
                MessageBox.Show("请设置所有参数", "提示", MessageBoxButtons.OK);
                return;
            }

            Common.SetConfigValue(Common._SavePath_key, fileSavePath);
            Common.SetConfigValue(Common._WorkCenterCode_key, workCenter);
            Common.SetConfigValue(Common._EquipmentCode_key, equipmentCode);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
