using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi
{
    public class WebApiConfig
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string ServerUrl { get; set; }
        public string ApiUrl { get { return ServerUrl + Url; } }
        public string ParamName { get; set; }
    }
}