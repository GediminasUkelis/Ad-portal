using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DAL.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
   
       IEnumerable<T> GetAll( Func<IQueryable<T>, IQueryable<T>> includes = null);

        List<T> GetAll();
        T GetById(Guid id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
      
    }
}
