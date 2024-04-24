using Bulky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.RepositoryBase.IRepository
{
    public interface ICategoryRepo:IGenericRepository<Category>
    {
        void Update(Category category);
      
    }
}
