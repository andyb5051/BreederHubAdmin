using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreederHub.DAL.Repositories
{
    public class UnitOfWork
    {
        private breederhubEntities _dbContext = new breederhubEntities();
        public Type currentType { get; set; }

        public BaseRepository<TEntity> GetRepositoryInstance<TEntity>() where TEntity : class {
            return new BaseRepository<TEntity>(this._dbContext);
        }

        public void SaveChanges()
        {
            this._dbContext.SaveChanges();
        }
    }
}
