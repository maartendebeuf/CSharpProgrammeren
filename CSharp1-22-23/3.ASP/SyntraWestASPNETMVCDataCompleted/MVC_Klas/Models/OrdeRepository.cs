namespace MVC_Klas.Models
{
    public class OrdeRepository
    {
        public OrdeRepository() {
            if(Globals._Orde == null)
            {
                Globals._Orde = new List<Orde>();

                Globals._Orde.Add(new Orde() { Naam = "Orde 1", Klasse = "Zoogdieren" });
                Globals._Orde.Add(new Orde() { Naam = "Orde 2" , Klasse = "Zoogdieren"});
                Globals._Orde.Add(new Orde() { Naam = "Orde 3", Klasse = "Reptielen en amfibiën"});
                Globals._Orde.Add(new Orde() { Naam = "Orde 4", Klasse = "Zoogdieren"});
            }
        } 

        public List<Orde> GetAll() { 
            return Globals._Orde; 
        }

        public Orde GetByNaam(string naam)
        {
            return Globals._Orde.Find(e => e.Naam == naam);
        }

        public void AddOrde(Orde familie)
        {
            if (GetByNaam(familie.Naam) == null)
            {
                Globals._Orde.Add(familie);
            }
        }

        public void UpdateOrde(Orde familie)
        {
            Orde aantepassen = GetByNaam(familie.Naam);
            if (aantepassen != null)
            {
                Globals._Orde.Remove(aantepassen);
                aantepassen = familie;
                Globals._Orde.Add(aantepassen);
            }
        }

        public void DeleteFamilie(string naam)
        {
            Orde te_verwijderen = GetByNaam(naam);
            if (te_verwijderen != null)
            {
                Globals._Orde.Remove(te_verwijderen);
            }
        }
    }
}
