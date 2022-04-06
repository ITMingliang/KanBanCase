using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace Juqent.CPS.ScreenSplit
{
    /// <summary>
    /// 文件帮助类
    /// </summary>
    public class FileHelper
    {
        //public static string sourcePath = @"\\cen-server\update_net\MES生产管理系统\MES_System_File";
        //public static string targetPath = string.Format(@"{0}\MES_System_File", Directory.GetParent(Directory.GetCurrentDirectory()).FullName);

        public static string serverPath = @"http://192.168.1.101:8088/";
        public static string filePostfix = ".html";

        public static string sourcePath = @"E:\Project\ryds.mes.client.workshop\bin\Debug";
        public static string targetPath = @"C:\Users\juqent\Desktop\客户端\workshop";
        public static IList<string> flist = null;
        public static bool IsCopySubDirectory = false;


        /// <summary>
        /// 复制文件
        /// </summary>
        /// <returns></returns>
        public static void CopyFile()
        {
            if (Directory.Exists(sourcePath))
            {
                //if (targetPath.IndexOf(@"\bin\") > 0)
                //{
                //    targetPath = Directory.GetParent(Directory.GetParent(targetPath).FullName).FullName;
                //}            

                if (!Directory.Exists(targetPath))
                {                    
                    Directory.CreateDirectory(targetPath);
                }

                string[] files = Directory.GetFiles(sourcePath, "*.*", IsCopySubDirectory ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                if (files.Length > 0)
                {          
                    string targetFile = string.Empty;
                    foreach (string file in files)
                    {
                        targetFile = file.Replace(sourcePath, targetPath);
                        if (!Directory.Exists(Directory.GetParent(targetFile).FullName))
                        {
                            Directory.CreateDirectory(Directory.GetParent(targetFile).FullName);
                        }
                        //File.SetAttributes(file, System.IO.FileAttributes.Normal);
                        //if (File.Exists(targetFile))
                        //{
                        //    File.SetAttributes(targetFile, System.IO.FileAttributes.Normal);
                        //}
                        if (flist != null && flist.Count>0)
                        {
                            if (flist.Contains(Path.GetFileName(file)))
                            {
                                File.Copy(file, targetFile, true);
                            }
                        }
                        else
                        {
                            File.Copy(file, targetFile, true);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 删除目标文件夹中的所有文件
        /// </summary>
        public static void DeleteFile(string targetPath)
        {
            if (Directory.Exists(targetPath))
            {
                Directory.Delete(targetPath, true);
            }
        }

        /// <summary>
        /// 杀掉指定程序进程
        /// </summary>
        /// <param name="processName">程序进程名称</param>
        public static void KillProcess(string processName)
        {
            System.Diagnostics.Process[] ps = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process item in ps)
            {
                if (item.ProcessName == processName)
                {
                    item.Kill();
                }
            }
        }

        /// <summary>
        /// 创建桌面快捷方式
        /// </summary>
        public static void CreateDesktopLnk(string targetpath, string desktopPath, string projectName)
        {
            string[] files = Directory.GetFiles(targetpath, string.Format("{0}.exe", projectName), SearchOption.AllDirectories);
            if (files.Length > 0)
            {
                IWshRuntimeLibrary.WshShell shell = new IWshRuntimeLibrary.WshShell();
                IWshRuntimeLibrary.IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(desktopPath);

                shortcut.TargetPath = files[0];
                shortcut.WorkingDirectory = Directory.GetParent(shortcut.TargetPath).FullName;
                shortcut.Arguments = "-ano";
                //shortcut.Hotkey = "CTRL+SHIFT+Z";//热键
                //shortcut.IconLocation = @"D:\software\cmpc\zy.exe,0";//图标
                //shortcut.Arguments = "";// 参数
                //shortcut.Description = "ERP系统";
                shortcut.WindowStyle = 1;
                shortcut.Save();
            }
        }

        #region Excel文件数据导入

        /// <summary>
        /// 从Excel表中读取数据到DataTable
        /// </summary>
        /// <param name="file"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTableByExcel(string file, string sql)
        {
            DataSet myDataSet = new DataSet();
            string strConn;
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + file + ";" +
            "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            OleDbDataAdapter myCommand = new OleDbDataAdapter(sql, strConn);
            myCommand.Fill(myDataSet);
            return myDataSet.Tables[0];
        }

        /// <summary>
        /// 从Excel表中读取数据到DataSet
        /// </summary>
        /// <param name="file"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSetByExcel(string file, string sql)
        {
            DataSet myDataSet = new DataSet();
            string strConn;
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + file + ";" +
            "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            OleDbDataAdapter myCommand = new OleDbDataAdapter(sql, strConn);
            myCommand.Fill(myDataSet);
            return myDataSet;
        }

        #endregion
    }
}
