using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Contexts
{
    public class TaskDataContext: DbContext
    {
        public TaskDataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var file = File.ReadAllText("./appsettings.json");
            var config = JsonConvert.DeserializeObject<Settings>(file);
            var connectionString = config.ConnectionStrings["CourseDatabase"];
            optionsBuilder.UseSqlServer(connectionString, (e) => { });
        }

        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<Models.Teacher> Teachers { get; set; }
    }
}
