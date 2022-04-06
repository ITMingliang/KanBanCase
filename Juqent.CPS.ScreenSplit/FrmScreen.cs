using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Threading;
using Juqent.CPS.WebApi;

namespace Juqent.CPS.ScreenSplit
{
    public class FormScreen
    {
        public FrmWeb Screen { get; set; }
        public int Index { get; set; }
    }
    public partial class FrmScreen : Form
    {
        public FrmScreen()
        {
            InitializeComponent();
        }
        //每页显示菜单个数
        public const int Size = 16;
        //总页数
        public int Page = 1;
       
        private int TabIndexStart = 15;
        private int TabIndexEnd = 30;
        private int PageIndex = 1;
        private List<PageInfoDto> lstPageInfo;
        List<Label> lstLabel;
        private List<FormScreen> lstScreen = new List<FormScreen> ();

        //窗体加载
        private void FrmScreen_Load(object sender, EventArgs e)
        {
            InitLabel();
            ShowLabel();


            this.lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            this.timer1.Start();            
            FrmScreen_Click(sender, e);
            //btnUp_Click(sender, e);
            InitPic();
            ShowPage();
        }

        private void InitLabel()
        {
            lstPageInfo = RemoteServer.Instance.GetPageInfo();
            if (lstPageInfo == null || lstPageInfo.Count < 1)
                throw new Exception("没有定义页面");
            lstLabel = new List<Label>();
            //计算总页数
            Page = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(lstPageInfo.Count)/Convert.ToDecimal(Size)));
            foreach (Control ctrl in this.Controls)
            {
                if (!(ctrl is Label) || ctrl.TabIndex < TabIndexStart || ctrl.TabIndex > TabIndexEnd)
                    continue;
                //ctrl.MouseDown += Ctrl_MouseDown;
                Label label = ctrl as Label;
                label.TextAlign = ContentAlignment.MiddleCenter;
                lstLabel.Add(label);
            }
            lstLabel = lstLabel.OrderBy(l => l.TabIndex).ToList();
        }

        private void Ctrl_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            lbl.DoDragDrop(lbl.Text, DragDropEffects.All);
        }

        private void ShowLabel()
        {
            foreach (Label lbl in lstLabel)
            {
                lbl.Text = string.Empty;
                lbl.Tag = null;
            }
            IEnumerable<PageInfoDto> ArrPageInfo = lstPageInfo.Where(p => p.PageIndex == PageIndex);
            if (ArrPageInfo == null || ArrPageInfo.Count() < 1)
                return;
            int Qty = lstLabel.Count < ArrPageInfo.Count() ? lstLabel.Count : ArrPageInfo.Count();
            for (int i = 0; i < Qty; i++)
            {
                Label label = lstLabel[i];
                PageInfoDto pageInfo = ArrPageInfo.ElementAt(i);
                label.Text = pageInfo.DisplayText;
                label.Tag = pageInfo;
            }
            ShowPage();
        }


        /// <summary>
        /// 初始化截图放置区域
        /// </summary>
        public void InitPic()
        {
            Screen[] sc = Screen.AllScreens;
            if (sc.Length > 0)
            {
                Image img = null;
                Bitmap b = null;
                //int index = -1;
                for (int i = 0; i < sc.Length; i++)
                {
                    if (sc[i].Bounds.Width != 1920 || sc[i].Bounds.Height != 1080)
                    {
                        ScreenHelper.ChangeResolution(1920, 1080, sc[i].DeviceName);
                    }      

                    #region 将图像放到指定区域

                    //index++;
                    b = ScreenHelper.CopyPrimaryScreen(sc[i].Bounds);
                    img = ScreenHelper.ResizeImage(b, new Size(pic1.Width, pic1.Height));
                    switch (i)
                    {
                        case 0:
                            this.pic1.Image = img;
                            this.pic1.Tag = i;
                            this.panel1.Tag = i;
                            break;
                        case 1:
                            this.pic2.Image = img;
                            this.pic2.Tag = i;
                            this.panel2.Tag = i;
                            break;
                        case 2:
                            this.pic3.Image = img;
                            this.pic3.Tag = i;
                            this.panel3.Tag = i;
                            break;
                        case 3:
                            this.pic4.Image = img;
                            this.pic4.Tag = i;
                            this.panel4.Tag = i;
                            break;
                        case 4:
                            this.pic5.Image = img;
                            this.pic5.Tag = i;
                            this.panel5.Tag = i;
                            break;
                        case 5:
                            this.pic6.Image = img;
                            this.pic6.Tag = i;
                            this.panel6.Tag = i;
                            break;
                    }

                    #endregion
                }
            }
        }

        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            InitPic();
        }

        //private void lblZhaiShengSha_DoubleClick(object sender, EventArgs e)
        //{
        //    Label lbl = sender as Label;
        //    string text = lbl.Text.Replace("\r\n", "").Trim();
        //    FrmWeb web = new FrmWeb(text);
        //    web.Show();
        //}

        private void pic1_Click(object sender, EventArgs e)
        {
            int index = 0;
            PictureBox pic = sender as PictureBox;
            if (pic.Tag != null && !string.IsNullOrEmpty(pic.Tag.ToString()))
            {
                index = Convert.ToInt32(pic.Tag);
            }
            Screen scn = ScreenHelper.GetScreen(index);
            MouseHelper.SetMouseAtCenterScreen(scn);
        }

        /// <summary>
        /// 鼠标回当前屏幕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmScreen_Click(object sender, EventArgs e)
        {
            Screen scn = ScreenHelper.GetPrimaryScreen();
            MouseHelper.SetMouseAtCenterScreen(scn);
        }

        private void lblShiXiaoLu_MouseDown(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            lbl.DoDragDrop(lbl.Tag, DragDropEffects.All);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            PageInfoDto pageInfo = e.Data.GetData(typeof(PageInfoDto)) as PageInfoDto;
            if (pageInfo == null)
                return;
            //string text = e.Data.GetData(DataFormats.Text).ToString();
            //text = text.Replace("\r\n", "").Trim();
            Panel pan = sender as Panel;
            int index = 0;
            if (pan.Tag != null && !string.IsNullOrEmpty(pan.Tag.ToString()))
            {
                index = Convert.ToInt32(pan.Tag);
            }
            //判断当前屏幕是否已经有投屏，是：关闭之前投屏然后重新new一个新的投屏；否：直接new一个投屏 梅浩 2018-8-10 09:26:24
            var lst = lstScreen.Where(r=>r.Index == index).FirstOrDefault();
            if (lst == null)
            {
                FrmWeb web = new FrmWeb(pageInfo);
                ScreenHelper.SetScreen(web, index);
                //web.CompOneEvent += web_compOneEvent;
                web.StartPosition = FormStartPosition.CenterScreen;
                FormScreen entity = new FormScreen();
                entity.Screen = web;
                entity.Index = index;
                lstScreen.Add(entity);
                web.Show();
            }
            else
            {
                FrmWeb webed = lst.Screen;
                webed.Close();
                lstScreen.Remove(lst);
                FrmWeb web = new FrmWeb(pageInfo);
                ScreenHelper.SetScreen(web, index);
                //web.CompOneEvent += web_compOneEvent;
                web.StartPosition = FormStartPosition.CenterScreen;
                FormScreen entity = new FormScreen();
                entity.Screen = web;
                entity.Index = index;
                lstScreen.Add(entity);
                web.Show();
            }
        }

        private void web_compOneEvent(int a)
        {
            if (a == 1)
            {
                InitPic(); 
            }            
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// 设置快捷键
        /// </summary>
        /// <param name="e"></param>
        private void setShortcuts(KeyEventArgs e)
        {
            Screen scn = ScreenHelper.GetPrimaryScreen();
            MouseHelper.SetMouseAtCenterScreen(scn);
        }

        private void ShowPage()
        {
            this.label4.Text = PageIndex.ToString() + "/" + Page.ToString();
         }

        /// <summary>
        /// 在窗体按下键之后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmScreen_KeyDown(object sender, KeyEventArgs e)
        {
            setShortcuts(e);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitPic();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            IEnumerable<PageInfoDto> arr = lstPageInfo.Where(p => p.PageIndex == (PageIndex - 1));
            if (arr == null || arr.Count() < 1)
                return;
            PageIndex--;
            ShowLabel();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            IEnumerable<PageInfoDto> arr = lstPageInfo.Where(p => p.PageIndex == (PageIndex + 1));
            if (arr == null || arr.Count() < 1)
                return;
            PageIndex++;
            ShowLabel();
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnUp_Click(object sender, EventArgs e)
        //{
        //    Label lbl = null;
        //    foreach (Control con in this.Controls)
        //    {
        //        if (con.GetType() == typeof(System.Windows.Forms.Label))
        //        {
        //            #region 设置文本

        //            lbl = con as Label;
        //            switch (lbl.TabIndex)
        //            {
        //                case 15:
        //                    lbl.Text = "\r\n 再生砂";
        //                    break;
        //                case 16:
        //                    lbl.Text = "\r\n 覆膜砂";
        //                    break;
        //                case 17:
        //                    lbl.Text = "\r\n KA800制芯机-1";
        //                    break;
        //                case 18:
        //                    lbl.Text = "\r\n KA800制芯机-2";
        //                    break;
        //                case 19:
        //                    lbl.Text = "\r\n KC800制芯机-1";
        //                    break;
        //                case 20:
        //                    lbl.Text = "\r\n KC800制芯机-2";
        //                    break;
        //                case 21:
        //                    lbl.Text = "\r\n 冷芯机";
        //                    break;
        //                case 22:
        //                    lbl.Text = "\r\n 集中熔化炉";
        //                    break;
        //                case 23:
        //                    lbl.Text = "\r\n浇注单元";
        //                    break;
        //                case 24:
        //                    lbl.Text = "\r\n切割单元";
        //                    break;
        //                case 25:
        //                    lbl.Text = "\r\n回转式热处理炉";
        //                    break;
        //                case 26:
        //                    lbl.Text = "\r\n燃烧室高度检测机";
        //                    break;
        //                case 27:
        //                    lbl.Text = "\r\nCNC自动化生产线";
        //                    break;
        //                case 28:
        //                    lbl.Text = "\r\n机器人清洗机";
        //                    break;
        //                case 29:
        //                    lbl.Text = "\r\n清洗机";
        //                    break;
        //                case 30:
        //                    lbl.Text = "\r\n气密性试漏机";
        //                    break;
        //            }
        //            #endregion
        //        }
        //    }
        //}

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void btnDown_Click(object sender, EventArgs e)
        //{
        //    Label lbl = null;
        //    foreach (Control con in this.Controls)
        //    {
        //        if (con.GetType() == typeof(System.Windows.Forms.Label))
        //        {
        //            #region 设置文本

        //            lbl = con as Label;
        //            switch (lbl.TabIndex)
        //            {
        //                case 15:
        //                    lbl.Text = "\r\n 压装机";
        //                    break;
        //                case 16:
        //                    lbl.Text = "\r\n 装配单元";
        //                    break;
        //                case 17:
        //                    lbl.Text = "\r\n 能耗监控";
        //                    break;
        //                case 18:
        //                    lbl.Text = "\r\n ";
        //                    break;
        //                case 19:
        //                    lbl.Text = "\r\n ";
        //                    break;
        //                case 20:
        //                    lbl.Text = "\r\n ";
        //                    break;
        //                case 21:
        //                    lbl.Text = "\r\n ";
        //                    break;
        //                case 22:
        //                    lbl.Text = "\r\n ";
        //                    break;
        //                case 23:
        //                    lbl.Text = "\r\n";
        //                    break;
        //                case 24:
        //                    lbl.Text = "\r\n";
        //                    break;
        //                case 25:
        //                    lbl.Text = "\r\n";
        //                    break;
        //                case 26:
        //                    lbl.Text = "\r\n";
        //                    break;
        //                case 27:
        //                    lbl.Text = "\r\n";
        //                    break;
        //                case 28:
        //                    lbl.Text = "\r\n";
        //                    break;
        //                case 29:
        //                    lbl.Text = "\r\n";
        //                    break;
        //                case 30:
        //                    lbl.Text = "\r\n";
        //                    break;  
        //            }

        //            #endregion
        //        }
        //    }
        //}
    }
}