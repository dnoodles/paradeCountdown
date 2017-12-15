using SantaTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace SantaTracker.Contexts
{
    public class ParadeContext : DbContext
    {
        public ParadeContext(DbContextOptions<ParadeContext> options) : base(options)
        {
        }
        public DbSet<Coordinates> Coordinates { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coordinates>().ToTable("Coordinate");
        }
    }
}