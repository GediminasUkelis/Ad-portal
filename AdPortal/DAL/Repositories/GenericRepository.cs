using DAL.Data;
using DAL.Extensions;
using DAL.Repositories.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
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
            if (obj == null)
            {
                throw new ArgumentNullException("obj Null");
            }
            entities.Remove(obj);
            context.SaveChanges();
        }
        public void Insert(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj Null");
            }
            entities.Add(obj);
            context.SaveChanges();
        }


        public void Update(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj Null");
            }
            entities.Update(obj);
            context.SaveChanges();
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
