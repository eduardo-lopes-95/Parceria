using Microsoft.EntityFrameworkCore;

namespace Parceria.Data
{
    internal sealed class AppDBContext : DbContext
    {
        public DbSet<Convite> Convites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=./Data/AppDB.db");
        
    }
}