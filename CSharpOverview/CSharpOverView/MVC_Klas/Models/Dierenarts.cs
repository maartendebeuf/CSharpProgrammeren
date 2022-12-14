using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System;
using System.Collections.Generic;

namespace MVC_Klas.Models
{
    public class Dierenarts
    {
        public string Naam{ get; set; }
        public string Adres { get; set; }   
        public string Gemeente { get; set;}

        [JsonPropertyName("Expertise")]
        public string Specialiatie { get; set;}

        public override string ToString() {
           return JsonSerializer.Serialize<Dierenarts>(this);
        }
    }
}
