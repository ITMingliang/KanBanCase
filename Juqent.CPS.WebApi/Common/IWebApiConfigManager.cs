using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi
{
    public interface IWebApiConfigManager : ICommonJsonConfig
    {
        string WebApiHostAddress { get; }

        string GetWebApiAddress(string key);
    }
    public interface ICommonJsonConfig
    {
        JsonConfig Configuration { get; }

        string Name { get; }

        int VersionNo { get; }

        string VersionName { get; }

        string GetJsonSetting(string key);
    }
    [Serializable]
    public class JsonConfig
    {
        public string Name { get; set; }
        public int VersionNo { get; set; }
        public string VersionName { get; set; }
        public IList<JsonNode> JsonSettings { get; set; }

        public JsonConfig()
        {
            JsonSettings = new List<JsonNode>();
        }
    }
    [Serializable]
    public class JsonNode
    {
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
