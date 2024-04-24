﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.RepositoryBase.IRepository
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);    
        void Delete(T entity);
        void RemoveRange(IEnumerable<T> entities);


    }
}
