using Juqent.CPS.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Xps.Packaging;

namespace Juqent.CPS.OperationGuide
{
    public partial class Form1 : Form
    {
        private ElementHost _ElementHost;
        private DocumentViewer _DocViewer;
        private PictureBox _PictureBox;
        private string[] _ImgExtension = { ".jpg", ".png" };
        private string[] _PdfExtension = { ".pdf" };
        List<EWIDocOutput> fileList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_DocViewer == null)
                _DocViewer = new System.Windows.Controls.DocumentViewer();
            elementHost1.Child = _DocViewer;

            try
            {
                fileList = Common.CheckFile();
            }
            catch (Exception ex)
            {
                //服务异常
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK);
                base.Close();
            }
        }

        #region 文档相关
        /// <summary>
        /// 初始化图片查看器
        /// </summary>
        private void InitPictureViewer()
        {
            if (_PictureBox == null)
            {
                _PictureBox = new System.Windows.Forms.PictureBox();
                _PictureBox.Dock = DockStyle.Fill;
                _PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                panel1.Controls.Add(_PictureBox);

            }
            panel1.Controls.SetChildIndex(_PictureBox, 0);
            //Application.DoEvents();
        }

        /// <summary>
        /// 初始化xps文档查看器
        /// </summary>
        private void InitOfficeViewer()
        {
            if (_ElementHost == null)
            {
                _ElementHost = new ElementHost();
                _ElementHost.Dock = DockStyle.Fill;
                panel1.Controls.Add(_ElementHost);
                _DocViewer = new System.Windows.Controls.DocumentViewer();
                _ElementHost.Child = _DocViewer;
            }
            panel1.Controls.SetChildIndex(_ElementHost, 0);
            Application.DoEvents();
        }

        /// <summary>
        /// 加载文件
        /// </summary>
        /// <param name="fileAllPath"></param>
        private void LoadDocument(string fileAllPath)
        {
            if (string.IsNullOrEmpty(fileAllPath))
                return;
            XpsDocument xpsDocument = new XpsDocument(fileAllPath, System.IO.FileAccess.Read);
            _DocViewer.Document = xpsDocument.GetFixedDocumentSequence();
            _DocViewer.FitToHeight();
            _DocViewer.FitToMaxPagesAcross(1);
            this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// 显示文档
        /// </summary>
        /// <param name="fileTypeCode"></param>
        public void ShowFile(string fileTypeCode)
        {
            string fileAllPath = string.Empty;
            string savepath = Common.GetConfigValue(Common._SavePath_key);
            if (fileList != null)
            {
                foreach (EWIDocOutput doc in fileList)
                {
                    if (doc.Exist && doc.DocTypeCode.ToUpper().Equals(fileTypeCode.ToUpper()))
                    {
                        fileAllPath = Path.Combine(savepath, doc.DocumentName);
                    }
                }
            }
            if (string.IsNullOrEmpty(fileAllPath))
            {
                MessageBox.Show("文件缺失", "提示", MessageBoxButtons.OK);
                return;
            }
            FileInfo fileInfo = new FileInfo(fileAllPath);
            string extension = fileInfo.Extension;
            switch (extension)
            {
                case ".jpg":
                case ".png":
                case ".jpeg":
                    InitPictureViewer();
                    _PictureBox.Image = System.Drawing.Image.FromFile(fileInfo.FullName);
                    break;
                default:
                    InitOfficeViewer();
                    LoadDocument(fileAllPath);
                    break;
            }
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion


        private void 系统配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCfig fc = new FCfig();
            fc.ShowDialog();
        }

        private void 配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCfig fc = new FCfig();
            fc.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowFile("sop");
        }

        private void 检查基准书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFile("sip");
        }
    }
}
