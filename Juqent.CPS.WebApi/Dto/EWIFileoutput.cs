using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juqent.CPS.WebApi.Dto
{
    public class EWIFileoutput
    {
        public string FileName { get; set; }
        public byte[] FileByte { get; set; }

        public bool Success { get; set; }
        public string Remark { get; set; }
    }
}
