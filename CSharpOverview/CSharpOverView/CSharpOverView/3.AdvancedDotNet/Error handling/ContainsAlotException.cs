using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOverView._3.AdvancedDotNet.Error_handling
{
    public class ContainsAlotException : Exception
    {
        public ContainsAlotException(string? message) : base(message)
        {

        }
    }
}