using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juqent.CPS.OperationGuide
{
    public partial class FConfig : Form
    {
        public FConfig()
        {
            InitializeComponent();
        }

        private void FConfig_Load(object sender, EventArgs e)
        {
            this.tbFileSavePath.Text = Common.GetConfigValue(Common._SavePath_key);
            this.tbWorkCenter.Text = Common.GetConfigValue(Common._WorkCenterCode_key);
            this.tbEquipmentCode.Text = Common.GetConfigValue(Common._EquipmentCode_key);
        }



        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX1_Click(object sender, EventArgs e)
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

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
