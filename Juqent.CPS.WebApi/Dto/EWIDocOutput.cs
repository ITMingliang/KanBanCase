using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi.Dto
{
    public class EWIDocOutput
    {
        public string DocTypeCode { get; set; }
        public string DocTypeName { get; set; }
        public string DocumentName { get; set; }
        public bool Exist { get; set; }
    }
}
