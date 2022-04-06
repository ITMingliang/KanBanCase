using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Juqent.CPS.WebApi
{
    public class TaskResultDto
    {
        public bool IsOK { get; set; }
        public long ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string ErrMsg { get; set; }
        public object obj { get; set; }
    }
}
