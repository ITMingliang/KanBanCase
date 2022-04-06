using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi
{
    public class ApiReqRetDto
    {
        //{"result":null,"targetUrl":null,"success":true,"error":null,"unAuthorizedRequest":false,"__abp":true}
        public object result { get; set; }
        public string targetUrl { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
        public bool unAuthorizedRequest { get; set; }
        public bool __abp { get; set; }
    }
}
