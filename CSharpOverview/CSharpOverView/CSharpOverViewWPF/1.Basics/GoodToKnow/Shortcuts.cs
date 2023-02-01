using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView.Shortcuts
{
    internal class Shortcuts
    {
        //*** _"prop"_**
        public int MyProperty1 { get; set; }


        //*** _"propfull"_**
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        //ctrl+k, ctrl+s
        #region MyRegion


        #endregion
    }
}
