using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zad7JakubKazimierski.Models.Services
{
    //Service manager interface with methods get, add, update, delete
  public  interface IDataService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
