using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Juqent.CPS.MvcWebApi
{
    public class StationPeriedTime
    {
        public string MoCode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int MoQty { get; set; }
        public decimal CompleteRate { get; set; }
        public string PeriedTime { get; set; }
        public int PeriedQty { get; set; }
        public int PeriedTargetQty { get;set;}
        public string StationType { get; set; }
    }
}