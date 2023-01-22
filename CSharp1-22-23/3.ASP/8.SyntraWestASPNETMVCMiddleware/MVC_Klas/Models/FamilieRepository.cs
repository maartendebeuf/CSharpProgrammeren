using Microsoft.EntityFrameworkCore;
using MVC_Klas.Services;

namespace MVC_Klas.Models
{
    public class FamilieRepository
    {
        private KlasContext _context;

        public FamilieRepository(KlasContext context) {
            _context = context;
            //if(Globals._Families == null)
            //{
            //    Globals._Families = new List<Familie>();

            //    Globals._Families.Add(new Familie() { Naam = "Knaagdieren", Klasse = "Zoogdieren", Orde = "Orde 1" });
            //    Globals._Families.Add(new Familie() { Naam = "Katachtigen", Klasse = "Zoogdieren", Orde = "Orde 2" });
            //    Globals._Families.Add(new Familie() { Naam = "Reptielen", Klasse = "Reptielen en amfibiën", Orde = "Orde 3" });
            //    Globals._Families.Add(new Familie() { Naam = "Honden", Klasse = "Zoogdieren", Orde = "Orde 2" });
            //}
        } 

        public List<Familie> GetAll() {
            return _context.Families.Include(e => e.Klasse).Include(e => e.Orde).ToList();
            //return Globals._Families; 
        }

        public Familie GetByNaam(string naam)
        {
            return _context.Families.FirstOrDefault(e => e.Naam == naam);
            //return Globals._Families.Find(e => e.Naam == naam);
        }

        public bool AddFamilie(Familie familie)
        {
            if (GetByNaam(familie.Naam) == null)
            {
                _context.Families.Add(familie);
                _context.SaveChanges();
                //Globals._Families.Add(familie);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateFamilie(Familie familie)
        {
            Familie aantepassen = GetByNaam(familie.Naam);
            if (aantepassen != null)
            {
                aantepassen.FamilieScore = familie.FamilieScore;
                aantepassen.KlasseID = familie.KlasseID;
                aantepassen.OrdeID = familie.OrdeID;
                aantepassen.Naam = familie.Naam;
                _context.SaveChanges();
                //Globals._Families.Remove(aantepassen);
                //aantepassen = familie;
                //Globals._Families.Add(aantepassen);
            }
        }

        public void DeleteFamilie(string naam)
        {
            Familie te_verwijderen = GetByNaam(naam);
            if (te_verwijderen != null)
            {
                _context.Families.Remove(te_verwijderen);
                _context.SaveChanges();
                //Globals._Families.Remove(te_verwijderen);
            }
        }
    }
}
