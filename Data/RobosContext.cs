using Microsoft.EntityFrameworkCore;
using robos.Data.Models;

namespace robos.Data
{
    public class RobosContext : DbContext
    {
        public DbSet<Robo> Robos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = robos.db");
        }
    }
}