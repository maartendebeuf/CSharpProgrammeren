using Microsoft.EntityFrameworkCore;
using MVC_Klas.Models;

namespace MVC_Klas.Services
{
    public class KlasContext : DbContext
    {
        public KlasContext(DbContextOptions<KlasContext> options) : base(options)
        {
        }

        public DbSet<Dier> Dieren { get; set; }
        public DbSet<Familie> Families { get; set; }
        public DbSet<Klasse> Klasses { get; set; }
        public DbSet<Orde> Ordes { get; set; }
        public DbSet<Dierenarts> Dierenartsen { get; set; }
    }
}
