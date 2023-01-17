using MVC_Klas.Interface;
using MVC_Klas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Klas.Models
{
    public class KlasseRepositoryInMem : IKlasseRepository
    {
        public KlasseRepositoryInMem()
        {
            if (Globals._Klasses == null)
            {
                Globals._Klasses = new List<Klasse>();

                Globals._Klasses.Add(new Klasse() { ID = 1, Naam = "Zoogdieren" });
                Globals._Klasses.Add(new Klasse() { ID = 2, Naam = "Reptielen en amfibiën" });
            }
        }

        public List<Klasse> GetAll()
        {
            return Globals._Klasses;
        }
    }
}
