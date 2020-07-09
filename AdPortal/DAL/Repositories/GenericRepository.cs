using DAL.Data;

using DAL.Repositories.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;

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

        public List<T> GetAll() => Query().AsNoTracking().ToList();
        public T GetById(Guid id)
        {
            var DbEntry = Query()
                .AsNoTracking()
                .SingleOrDefault(s => s.Id == id);
                  
            return DbEntry;
        }

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
            entities.Update(obj);
            //context.Entry(obj).State = EntityState.Modified;
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


      
    }
}
