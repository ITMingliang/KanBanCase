using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Juqent.CPS.WebApi
{
    public class WebApiUrl
    {
        private static string ConfigFile = string.Empty;
        private static string ServerUrl;
        private static List<WebApiConfig> lstWebApiConfig = null;

        public static void Initial()
        {
            string ExecutablePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            ExecutablePath = ExecutablePath.TrimStart(new char[] { 'f', 'i', 'l', 'e', ':', '\\' });
            ConfigFile = Path.Combine(ExecutablePath, "WebApiUrl.xml");
        }

        private static void InitialConfig()
        {
            lstWebApiConfig = new List<WebApiConfig>();
            Initial();
            if (!File.Exists(ConfigFile))
                throw new Exception("找不到 WebApi 配置文档");
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(ConfigFile);
            XmlNodeList nodes = XmlDoc.DocumentElement.SelectNodes("WebApi");
            if (nodes == null || nodes.Count < 1)
                throw new Exception("WebApi 配置为空");
            foreach (XmlNode Item in nodes)
            {
                if (Item.Attributes["Code"].Value == "ServerUrl")
                {
                    ServerUrl = Item.Attributes["Url"].Value;
                    continue;
                }
                WebApiConfig Cfg = new WebApiConfig
                {
                    Code = Item.Attributes["Code"].Value,
                    Name = Item.Attributes["Name"].Value,
                    Description = Item.Attributes["Description"].Value,
                    Url = Item.Attributes["Url"].Value,
                    ServerUrl = ServerUrl,
                };
                lstWebApiConfig.Add(Cfg);
            }
            if (lstWebApiConfig == null || lstWebApiConfig.Count < 1)
                throw new Exception("初始化WebApi配置失败");
            if (String.IsNullOrEmpty(ServerUrl))
            {
                lstWebApiConfig = null;
                throw new Exception("ServerUrl为空");
            }
        }

        public static WebApiConfig GetWebApiConfig(string Code)
        {
            if (String.IsNullOrEmpty(Code))
                throw new Exception("WebApi配置编码不能为空");
            if (lstWebApiConfig == null || lstWebApiConfig.Count < 1)
                InitialConfig();
            IEnumerable<WebApiConfig> Arr = lstWebApiConfig.Where(w => w.Code == Code);
            if (Arr == null || Arr.Count() < 1)
                throw new Exception("找不到WebApi配置：" + Code);
            return Arr.First();
        }
    }
}