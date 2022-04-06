using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi.Dto
{
    /// <summary>
    /// 请求EWI服务使用
    /// </summary>
    public class EWIResultDto
    {
        public object result { get; set; }
        public string targetUrl { get; set; }
        public bool success { get; set; }
        public object error { get; set; }
        public bool unAuthorizedRequest { get; set; }
        public bool __abp { get; set; }
    }
}
