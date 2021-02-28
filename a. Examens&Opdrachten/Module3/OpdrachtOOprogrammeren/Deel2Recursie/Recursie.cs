using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deel2Recursie
{
    class Recursie
    {        
        public int NatuurlijkGetal(int getal)
        {
            int uitkomst;
            if (getal < 10)
            {
                Console.Write(getal+ " = ");
                return getal;
            }
            int natuurlijkGetal = getal % 10;
            Console.Write((getal % 10) + " + ");
            uitkomst = natuurlijkGetal + NatuurlijkGetal(getal / 10);
                             
            return uitkomst;
        }
    }
}
