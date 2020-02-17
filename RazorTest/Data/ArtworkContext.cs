using Microsoft.EntityFrameworkCore;
using RazorTest.Models;

namespace RazorTest.Data
{
    public class ArtworkContext : DbContext
    {
        public ArtworkContext(DbContextOptions<ArtworkContext> options) : base(options) { }

        public DbSet<Artwork> Artwork { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artwork>().ToTable("Artwork");
        }
    }
}
