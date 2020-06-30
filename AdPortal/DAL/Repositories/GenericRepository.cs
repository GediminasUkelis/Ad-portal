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
        public T GetById(Guid id)
        {
            var DbEntry = Query().SingleOrDefault(s => s.Id == id);
            if(DbEntry==null)
            {
                var response = new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("{0} doesn't exist", System.Text.Encoding.UTF8, "text/plain"),
                    StatusCode = HttpStatusCode.NotFound
                };
                 throw new HttpResponseException(response);
            }
               
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


      
    }
}
