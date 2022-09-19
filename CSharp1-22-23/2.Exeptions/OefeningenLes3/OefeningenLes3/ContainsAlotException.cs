using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes3
{
    public class ContainsAlotException: Exception 
    {
        public ContainsAlotException(string? message) : base(message)
        {

        }
    }
}
