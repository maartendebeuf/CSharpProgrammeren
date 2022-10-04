using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Models
{
    public class Course
    {
        public int ID { get; set; }
        public int TeacherID { get; set; }
        [ForeignKey("TeacherID")]
        public Teacher Teacher { get; set; }
        //public int PersonID { get; set; }
        //[ForeignKey("PersonID")]
        //public Teacher Person { get; set; }
    }
}
