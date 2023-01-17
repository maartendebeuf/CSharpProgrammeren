using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Klas.Models
{
    public class KlasseRepository
    {
        public KlasseRepository()
        {
            if (Globals._Klasses == null)
            {
                Globals._Klasses = new List<Klasse>();

                Globals._Klasses.Add(new Klasse() { Naam = "Zoogdieren"});
                Globals._Klasses.Add(new Klasse() { Naam = "Reptielen en amfibiën"});
            }
        }

        public List<Klasse> GetAll()
        {
            return Globals._Klasses;
        }
    }
}
