using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework2.Models
{
    public class Task
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        //Enable-Migrations
        //Add-Migration Initial
        //Update-database
    }
}
