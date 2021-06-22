using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenopdracht
{
    public class Computer : Object
    {

        public string Type { get; set; }
        public string UniekeComputernaam { get; set; }
        public int Bouwjaar { get; set; }
        public int ComputerLeeftijd{ get; set; }
        public decimal Aankoopprijs { get; set; }
        public List<Software> SoftwareLijst { get; set; }

        public Computer NieuwComputerAanmaken(string type, string uniekeComputernaam, int bouwjaar, decimal aankoopprijs, List<Software> softwareLijst)
        {
            Type = type;
            UniekeComputernaam = uniekeComputernaam;
            Bouwjaar = bouwjaar;
            BerekenComputerLeeftijd();
            Aankoopprijs = aankoopprijs;
            SoftwareLijst = softwareLijst;
            return this;
        }

        private void BerekenComputerLeeftijd()
        {
            DateTime huidigDateTime = DateTime.Now;
            int huidigJaar = huidigDateTime.Year;
            ComputerLeeftijd = huidigJaar - Bouwjaar;
           
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Type = {Type}");
            stringBuilder.AppendLine($"\nComputernaam = {UniekeComputernaam}");
            stringBuilder.AppendLine($"\nBouwjaar = {Bouwjaar}");
            stringBuilder.AppendLine($"\nLeeftijd = {ComputerLeeftijd}");
            stringBuilder.AppendLine($"\nAankoopprijs = {Aankoopprijs}");

            return stringBuilder.ToString();
        }

    }
}
