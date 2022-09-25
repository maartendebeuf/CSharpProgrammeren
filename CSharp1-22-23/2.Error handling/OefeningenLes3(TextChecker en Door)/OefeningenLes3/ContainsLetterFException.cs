using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes3
{
    public class ContainsLetterFException : Exception
    {
        public ContainsLetterFException(string? message) : base(message)
        {

        }
    }
}
