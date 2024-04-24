using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.RepositoryBase.IRepository
{
    public interface IUniteOfWork
    {
        //User classes
        ICategoryRepo categoryRepo { get; }
        void save();

    }
}
