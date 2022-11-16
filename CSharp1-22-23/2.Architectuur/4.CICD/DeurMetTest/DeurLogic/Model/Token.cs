using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeurLogic.Model;

namespace DeurLogic
{
    public class Token
    {
        public Token(int tokenId, List<int> deurNummers, DeurStatus status)
        {
            TokenId = tokenId;
            foreach(var deurNummer in deurNummers)
            {
                var deur = new Deur(deurNummer);
                ToegangDeur.Add(deur);
            }
            Status = status;

        }
        public int TokenId { get; set; }
        public List<Deur> ToegangDeur { get; set; } = new List<Deur>();
        public DeurStatus Status { get; set; }
    }
    public enum DeurStatus
    {
        Actief,
        Geblokkeerd
    }
}
