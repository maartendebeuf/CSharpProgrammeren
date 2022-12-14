namespace MVC_Klas.Models
{
    public class FamilieRepository
    {
        public FamilieRepository()
        {
            if (Globals._Families == null)
            {
                Globals._Families = new List<Familie>();
                Familie x = new Familie();
                x.Naam = "Katachtigen";
                x.Orde = "Roofdier";
                x.Klasse = "Zoogdieren";
                Globals._Families.Add(x);

                x = new Familie();
                x.Naam = "Leeuw";
                x.Orde = "Roofdier";
                x.Klasse = "Zoogdieren";
                Globals._Families.Add(x);
            }
        }

        public List<Familie> GetAll()
        {
            return Globals._Families;
        }

        public Familie GetByBenaming(string benaming)
        {

            return Globals._Families.Find(e => e.Naam == benaming);

        }

        public void UpdateFamilie(Familie familie)
        {
            Familie aantepassen = GetByBenaming(familie.Naam);
            if (aantepassen != null)
            {
                Globals._Families.Remove(aantepassen);
                aantepassen = familie;
                Globals._Families.Add(aantepassen);
            }
        }

        public void DeleteFamilie(string benaming)
        {
            Familie te_verwijderen = GetByBenaming(benaming);
            if (te_verwijderen != null)
            {
                Globals._Families.Remove(te_verwijderen);
            }
        }
    }
}
