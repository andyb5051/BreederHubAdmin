using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreederHub.DAL.Repositories.Interfaces;
using System.Data.Entity;

namespace BreederHub.DAL.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        DbSet<TEntity> _dbSet;
        private breederhubEntities _dbContext;

        public BaseRepository(breederhubEntities dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = this._dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this._dbSet.ToList();
        }

        public void Add(TEntity entity)
        {
            this._dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            if (this._dbContext.Entry(entity).State == EntityState.Detached)
                this._dbSet.Attach(entity);
            this._dbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            this._dbSet.Attach(entity);
            this._dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
