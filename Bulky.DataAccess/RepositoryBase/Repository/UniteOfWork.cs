using Bulky.DataAccess.Data;
using Bulky.DataAccess.RepositoryBase.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.RepositoryBase.Repository
{
    public class UniteOfWork : IUniteOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICategoryRepo categoryRepo {  get; private set; }
        public UniteOfWork(ApplicationDbContext dbContext)
        {
            _db= dbContext;

            // ??
             categoryRepo=new CategoryRepo(dbContext);
        }
        public void save()
        {
            _db.SaveChanges();
        }
    }
}
