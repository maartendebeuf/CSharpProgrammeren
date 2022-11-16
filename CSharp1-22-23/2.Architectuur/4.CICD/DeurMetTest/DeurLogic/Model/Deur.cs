using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeurLogic.Model
{
    public class Deur
    {
        public Deur(int deurId)
        {
            DeurId = deurId;
        }

        public int DeurId { get; set; }
    }
}
