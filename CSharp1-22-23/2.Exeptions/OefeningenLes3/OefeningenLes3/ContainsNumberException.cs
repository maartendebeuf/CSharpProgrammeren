using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes3
{
    public class ContainsNumberException : Exception
    {
        public ContainsNumberException(string? message) : base(message)
        {

        }
    }
}
