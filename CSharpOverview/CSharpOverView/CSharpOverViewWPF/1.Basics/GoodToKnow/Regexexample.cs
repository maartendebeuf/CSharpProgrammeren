using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpOverViewWPF._1.Basics.GoodToKnow
{
    internal class Regexexample
    {
        public void regex()
        {
            //Regex voor hexadecimaal
            Regex regex = new Regex(@"^([0-9]|[a-fA-F])*$");
        }
    }
}
