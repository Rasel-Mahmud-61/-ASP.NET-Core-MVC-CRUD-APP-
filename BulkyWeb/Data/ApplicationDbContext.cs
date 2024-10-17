using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "rasel", DisplayOrder = 1 },
                new Category { Id = 2, Name = "MAHMUF", DisplayOrder = 2 },
                new Category { Id = 3, Name = "hELLO", DisplayOrder = 3 }
                );

        }
    }
}
