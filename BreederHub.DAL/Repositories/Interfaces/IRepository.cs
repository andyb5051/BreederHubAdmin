using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BreederHub.DAL.Repositories.Interfaces
{
    interface IRepository<TEntity> where TEntity : class
    {

        IEnumerable<TEntity> GetAll();

        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
