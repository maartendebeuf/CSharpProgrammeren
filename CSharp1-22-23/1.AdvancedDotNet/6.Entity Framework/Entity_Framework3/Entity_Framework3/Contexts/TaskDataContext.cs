using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework3.Contexts
{
    public class TaskDataContext : DbContext
    {
        public TaskDataContext() : base("TaskDatabase2")
        {

        }
        public DbSet<Models.Task2> Tasks2 { get; set; }
    }
}
