namespace MVC_Klas.Models
{
    public class FamilieRepository
    {
        public FamilieRepository() {
            if(Globals._Families == null)
            {
                Globals._Families = new List<Familie>();

                Globals._Families.Add(new Familie() { Naam = "Knaagdieren", Klasse = "Zoogdieren", Orde = "Orde 1" });
                Globals._Families.Add(new Familie() { Naam = "Katachtigen", Klasse = "Zoogdieren", Orde = "Orde 2" });
                Globals._Families.Add(new Familie() { Naam = "Reptielen", Klasse = "Reptielen en amfibiën", Orde = "Orde 3" });
                Globals._Families.Add(new Familie() { Naam = "Honden", Klasse = "Zoogdieren", Orde = "Orde 2" });
            }
        } 

        public List<Familie> GetAll() { 
            return Globals._Families; 
        }

        public Familie GetByNaam(string naam)
        {
            return Globals._Families.Find(e => e.Naam == naam);
        }

        public void AddFamilie(Familie familie)
        {
            if (GetByNaam(familie.Naam) == null)
            {
                Globals._Families.Add(familie);
            }
        }

        public void UpdateFamilie(Familie familie)
        {
            Familie aantepassen = GetByNaam(familie.Naam);
            if (aantepassen != null)
            {
                Globals._Families.Remove(aantepassen);
                aantepassen = familie;
                Globals._Families.Add(aantepassen);
            }
        }

        public void DeleteFamilie(string naam)
        {
            Familie te_verwijderen = GetByNaam(naam);
            if (te_verwijderen != null)
            {
                Globals._Families.Remove(te_verwijderen);
            }
        }
    }
}
