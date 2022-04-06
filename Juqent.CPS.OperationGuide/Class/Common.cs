using Juqent.CPS.WebApi;
using Juqent.CPS.WebApi.Dto;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juqent.CPS.OperationGuide
{
    public static class Common
    {
        #region 常量
        /// <summary>
        ///文件保存路径
        /// </summary>
        public const string _SavePath_key = "SavePath";
        /// <summary>
        /// 工作中心编号
        /// </summary>
        public const string _WorkCenterCode_key = "WorkCenterCode";
        /// <summary>
        /// 设备编号
        /// </summary>
        public const string _EquipmentCode_key = "EquipmentCode";
        /// <summary>
        /// 文件列表缓存目录
        /// </summary>
        public static string _FileListTempPath
        {
            get { return Path.Combine(Environment.CurrentDirectory, "_FileListTempPath.txt"); }
        }
        #endregion

        /// <summary>
        /// 获取配置文件值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConfigValue(string key)
        {
            Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string value = cf.AppSettings.Settings[key].Value;
            return value;
        }

        /// <summary>
        /// 设置配置文件节点
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetConfigValue(string key, string value)
        {
            Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cf.AppSettings.Settings[key].Value = value;
            cf.Save();
        }

        /// <summary>
        /// 检验文件，如本地缺少，则下载
        /// </summary>
        public static List<EWIDocOutput> CheckFile()
        {
            List<EWIDocOutput> fileList = RemoteServer.Instance.GetFileName(new WebApi.Dto.EWIDocInput() { WorkCenterCode = Common.GetConfigValue(Common._WorkCenterCode_key), EquipmentCode = Common.GetConfigValue(Common._EquipmentCode_key) });

            string savepath = Common.GetConfigValue(Common._SavePath_key);
            bool downloadSuccess = false;
            foreach (EWIDocOutput file in fileList)
            {
                downloadSuccess = false;
                string fileAllPath = Path.Combine(savepath, file.DocumentName);
                FileInfo info = new FileInfo(fileAllPath);
                if (!info.Exists)
                {
                    downloadSuccess = RemoteServer.Instance.GetFile(savepath, new EWIFileInput() { fileName = file.DocumentName });
                    if (downloadSuccess)
                    {
                        file.Exist = true;
                    }
                }
                else
                {
                    file.Exist = true;
                }
            }
            return fileList;
        }

        /// <summary>
        /// 将内容保存在txt
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="content"></param>
        public static void WriteTxt(string filePath, string content)
        {
            FileInfo info = new FileInfo(filePath);
            if (info.Exists)
            {
                info.Delete();
            }
            FileStream fs = new FileStream(filePath, FileMode.Create);
            //获得字节数组
            byte[] data = System.Text.Encoding.UTF8.GetBytes(content);
            //开始写入
            fs.Write(data, 0, data.Length);
            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }

        /// <summary>
        /// 读取txt内容
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static string ReadText(string filePath)
        {
            if (!new FileInfo(filePath).Exists) return string.Empty;
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                sb.Append(line.ToString());
            }
            return sb.ToString();
        }
    }
}
