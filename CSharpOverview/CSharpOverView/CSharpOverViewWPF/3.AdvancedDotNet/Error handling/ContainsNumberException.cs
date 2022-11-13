using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._3.AdvancedDotNet.Error_handling
{
    internal class ContainsNumberException : Exception
    {
        public ContainsNumberException(string? message) : base(message)
        {

        }
    }
}
