using Microsoft.EntityFrameworkCore;
using RazorPages_Temp.Model;

namespace RazorPages_Temp.Data
{
    public class AplicationDbcontext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public AplicationDbcontext(DbContextOptions dbContext):base(dbContext)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, DispalyOrder = 1, Name = "Actionnnn" },
                new Category { CategoryId = 3, DispalyOrder = 4, Name = "dramnnnn" },
                new Category { CategoryId = 2, DispalyOrder = 8, Name = "Agggggggionnnn" }
            );
        }
    }
}
