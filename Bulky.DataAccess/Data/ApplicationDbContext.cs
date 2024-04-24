using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions option):base(option) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, Name = "Action", DispalyOrder = 1 },
                new Category { CategoryId = 2, Name = "Drama", DispalyOrder = 2 },
                new Category { CategoryId = 3, Name = "History", DispalyOrder = 3 },
                new Category { CategoryId = 4, Name = "Science", DispalyOrder = 4 }



                );
            
        }
    }
}
