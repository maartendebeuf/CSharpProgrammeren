using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Repository.Models
{
    public class tbl_test
    {
        [Key]
        public int Idx { get; set; }
        public string Col1 { get; set; }
    }
}
