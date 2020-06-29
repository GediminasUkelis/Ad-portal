using DAL.Data;
using DAL.Extensions;
using DAL.Repositories.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
    {
        private ApplicationDbContext context;
        private DbSet<T> entities;

        public GenericRepository(ApplicationDbContext _context)
        {
           
            context = _context;
            entities = context.Set<T>();
        }

        public List<T> GetAll() => Query().ToList();
        public T GetById(Guid id) => Query().SingleOrDefault(s => s.Id == id);

        public void Delete(T obj)
        {
            T entityToDelete = entities.Find(obj.Id);
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                entities.Attach(entityToDelete);
            }

            entities.Remove(entityToDelete);
        }
        public void Insert(T obj)
        {
            entities.Add(obj);
        }


        public void Update(T obj)
        {
            entities.Attach(obj);
            context.Entry(obj).State = EntityState.Modified;
        }
        public IQueryable<T> Query()
        {
            var query = entities.AsQueryable();

            foreach (var property in context.Model.FindEntityType(typeof(T)).GetNavigations())
            {

                query = query.Include(property.Name);
            }
            return query;

        }



        protected IQueryable<T> QueryDb(Expression<Func<T, bool>> filter,  Func<IQueryable<T>, IQueryable<T>> includes)
        {
            IQueryable<T> query = context.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includes != null)
            {
                query = includes(query);
            }

            

            return query;
        }

        public IEnumerable<T> GetAll(Func<IQueryable<T>, IQueryable<T>> includes = null)
        {
            var result = QueryDb(null, includes);
            return result.ToList();
        }
    }
}
