using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Klas.Models
{
    public class Dierenarts
    {
        //id toevoegen aan model 
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Naam{ get; set; }
        public string Adres { get; set; }   
        public string Gemeente { get; set;}
        //fkey naar familie en
        [Display(Name = "Specialiatie")]
        [ForeignKey("Familie")]
        public int FamilieID{ get; set;}
        public Familie Familie{ get; set;}

        public override string ToString() {
           return Naam;
        }
    }
}
