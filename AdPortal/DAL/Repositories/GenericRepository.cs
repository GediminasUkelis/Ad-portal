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

        public async Task<List<T>> GetAll() => await Query().AsNoTracking().ToListAsync();
        public async Task<T> GetById(Guid id)
        {
            var DbEntry = Query()
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == id);
                  
            return await DbEntry;
        }
        
        public async Task Delete(T obj)
        {
            T entityToDelete = await entities.FindAsync(obj.Id);
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                entities.Attach(entityToDelete);
            }

            entities.Remove(entityToDelete);
        }
        public async Task Insert(T obj)
        {
            await entities.AddAsync(obj);
        }

        public async Task Update(T obj)
        {
            context.Entry(await GetById(obj.Id)).CurrentValues.SetValues(obj);
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
