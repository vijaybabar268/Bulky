using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {            
        }

        public DbSet<Category> Categories { get; set; }

        // Using method to Seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categoriesList = new List<Category>()
            {
                new Category() { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category() { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category() { Id = 3, Name = "History", DisplayOrder = 3 }
            };
            modelBuilder.Entity<Category>().HasData(categoriesList);
        }
    }
}
