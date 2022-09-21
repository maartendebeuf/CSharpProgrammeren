using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntraWestAdvancedDotNetLINQClassExample1
{
    public class Course
    {
        public string Teacher { get; set; }
        public EnumPeriod Period { get; set; }
        public int Duration { get; set; }
        public int StudentCount { get; set; }
        public string Room { get; set; }
    }
}
