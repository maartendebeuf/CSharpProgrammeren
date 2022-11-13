using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView.Shortcuts
{
    internal class Shortcuts
    {
        public int MyProperty1 { get; set; }//*** _"prop"_**

        private int myVar;//*** _"propfull"_**
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
    }
}
