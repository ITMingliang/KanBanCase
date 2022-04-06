using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi
{
    public class PageInfoDto
    {
        public int PageIndex { get; set; }
        public int Sequence { get; set; }
        public string Code { get; set; }
        public string DisplayText { get; set; }
        public string Url { get; set; }
    }
}
