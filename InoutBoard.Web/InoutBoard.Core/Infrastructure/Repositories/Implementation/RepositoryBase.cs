using InoutBoard.Core.Infrastructure.Providers;
using InoutBoard.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoutBoard.Core.Infrastructure.Repositories
{
    public abstract class RepositoryBase<TEntity> where TEntity : class, IEntity
    {

        private InoutContext database;

        public RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        public InoutContext Database
        {
            get
            {
                return database ?? (database = DatabaseFactory.Get());
            }
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        public virtual void Add(TEntity entity)
        {
            Database.Set<TEntity>().Add(entity);
        }

        public void Add<T>(T entity) where T : class, IEntity
        {
            Database.Set<T>().Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            Database.Set<TEntity>().Remove(entity);
        }

        public void Delete<T>(T entity) where T : class, IEntity
        {
            Database.Set<T>().Remove(entity);
        }

        public virtual void Save()
        {
            Database.SaveChanges();
        }

        public virtual TEntity GetById(int id)
        {
            return Database.Set<TEntity>().Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return Database.Set<TEntity>();
        }
    }

}
