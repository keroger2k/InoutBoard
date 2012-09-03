using InoutBoard.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InoutBoard.Core.Infrastructure.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Save();
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
    }
}
