using Aspose.Slides;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Juqent.CPS.OperationGuide
{
   public class Office2XPSByAspose
    {
        public static void Goto(string sourceDoc, string saveDoc)
        {
            string s_sourceDoc = sourceDoc;

            string s_saveDoc = saveDoc;
            CheckPath(saveDoc);
            string docExtendName = Path.GetExtension(s_sourceDoc).ToLower();

            switch (docExtendName)
            {
                case ".doc":
                case ".docx":
                    Aspose.Words.Document doc = new Aspose.Words.Document(s_sourceDoc);
                    doc.Save(s_saveDoc, Aspose.Words.SaveFormat.Xps);
                    break;
                case ".xls":
                case ".xlsx":
                    Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook(s_sourceDoc);
                    workbook.Save(s_saveDoc, Aspose.Cells.SaveFormat.XPS);
                    break;
                case ".ppt":
                case ".pptx":
                    CrackSlide();
                    Presentation pres = new Presentation(s_sourceDoc);
                    pres.Save(s_saveDoc, Aspose.Slides.Export.SaveFormat.Xps);
                    break;
                case ".pdf":
                    Aspose.Pdf.Document pdf = new Aspose.Pdf.Document(s_sourceDoc);
                    pdf.Save(s_saveDoc, Aspose.Pdf.SaveFormat.Xps);
                    break;
            }
        }

        /// <summary>
        /// 检验路劲，不存在的文件夹则新增
        /// </summary>
        private static void CheckPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            String[] paths = path.Split('\\');
            String dir = paths[0];
            for (int i = 0; i < paths.Length - 2; i++)
            {//注意此处循环的长度  
                dir = dir + "/" + paths[i + 1];
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }

        }

        /*使用Apose前调用一次软破解即可*/
        private static void CrackSlide()
        {
            string[] stModule = new string[8]
            {
                "\u0002\u2006\u2006\u2003",
                "\u0003\u2006\u2006\u2003",
                "\u0005\u2005\u2000\u2003",
                "\u0003\u2000",
                "\u000F",
                "\u0002\u2000",
                "\u0003",
                "\u0002"
            };
            Assembly assembly = Assembly.GetAssembly(typeof(Aspose.Slides.License));


            Type typeLic = null, typeIsTrial = null, typeHelper = null;

            foreach (Type type in assembly.GetTypes())
            {
                if ((typeLic == null) && (type.Name == stModule[0]))
                {
                    typeLic = type;
                }
                else if ((typeIsTrial == null) && (type.Name == stModule[1]))
                {
                    typeIsTrial = type;
                }
                else if ((typeHelper == null) && (type.Name == stModule[2]))
                {
                    typeHelper = type;
                }
            }
            if (typeLic == null || typeIsTrial == null || typeHelper == null)
            {
                throw new Exception();
            }
            object lic = Activator.CreateInstance(typeLic);
            int findCount = 0;

            foreach (FieldInfo field in typeLic.GetFields(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance))
            {
                if (field.FieldType == typeLic && field.Name == stModule[3])
                {
                    field.SetValue(null, lic);
                    ++findCount;
                }
                else if (field.FieldType == typeof(DateTime) && field.Name == stModule[4])
                {
                    field.SetValue(lic, DateTime.MaxValue);
                    ++findCount;
                }
                else if (field.FieldType == typeIsTrial && field.Name == stModule[5])
                {
                    field.SetValue(lic, 1);
                    ++findCount;
                }

            }
            foreach (FieldInfo field in typeHelper.GetFields(BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance))
            {
                if (field.FieldType == typeof(bool) && field.Name == stModule[6])
                {
                    field.SetValue(null, false);
                    ++findCount;
                }
                if (field.FieldType == typeof(int) && field.Name == stModule[7])
                {
                    field.SetValue(null, 128);
                    ++findCount;
                }
            }
            if (findCount < 5)
            {
                throw new NotSupportedException("无效的版本");
            }
        }
    }
}
