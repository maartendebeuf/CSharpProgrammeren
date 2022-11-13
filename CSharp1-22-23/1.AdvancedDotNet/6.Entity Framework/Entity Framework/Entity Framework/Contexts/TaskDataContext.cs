using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Contexts
{
    public class TaskDataContext : DbContext
    {
        public TaskDataContext() : base("TaskDatabase")
        {

        }
        public DbSet<Models.Task> Tasks { get; set; }
    }
}
