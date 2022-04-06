using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Juqent.CPS.MvcWebApi
{
    public class MoOutput
    {
        public string MoCode { get; set; }
        public string SectionType { get; set; }
        public int MoNum { get; set; }
        public int CompleteNum { get; set; }
        public decimal MoRate { get; set; }
        public string MoStatus { get; set; }
    }
}