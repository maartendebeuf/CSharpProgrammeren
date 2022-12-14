using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    internal class LocalDBContext : DbContext
    {
        public static string _connectionString = "Server=MSI-MAARTEN; Database=testdb;Trusted_Connection=True; User Id=Tester;Password=Test; TrustServerCertificate=True";
        LocalDBContext _context;
        public LocalDBContext() : base()
        {
            string ConnStr = _connectionString;
            //Database.SetConnectionString(ConnStr);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  base.OnConfiguring(optionsBuilder);
            string connectionString = _connectionString;
            //  optionsBuilder.UseSqlServer(connectionString, (e) => { });
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Models.tbl_test> tbl_test { get; set; }

    }
}
