using Bulky.DataAccess.Data;
using Bulky.DataAccess.RepositoryBase.IRepository;
using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.RepositoryBase.Repository
{
    public class CategoryRepo :  GenericRepository<Category>, ICategoryRepo
    {

        private readonly ApplicationDbContext _context;
        public CategoryRepo(ApplicationDbContext dbContext):base(dbContext)
        {
            _context = dbContext;
        }

       
        public void Update(Category category)
        {
            _context.Update(category);
        }
    }
}
