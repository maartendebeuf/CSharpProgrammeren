using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OefeningenLes4_1
{
    public class House
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public decimal Price { get; set; }
        public int BedroomCount { get; set; }
        public decimal Squaremeter { get; set; }
        public EnumType EnumType { get; set; }
    }
}
