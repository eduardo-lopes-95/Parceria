using Microsoft.EntityFrameworkCore;

namespace Parceria.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Convite> Convites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlServer("Data Source=./Data/AppDB.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Convite>().ToTable(("Parcerias"));
        }
    }
}