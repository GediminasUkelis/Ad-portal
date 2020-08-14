using DAL.Data;
using DAL.Repositories.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CarRepository : ICarRepository
    {
        private ApplicationDbContext context;
        private DbSet<Car> entities;

        public CarRepository(ApplicationDbContext _context)
        {
            context = _context;
            entities = context.Set<Car>();
        }
        public async Task<List<Car>> GetAll() => await context.Cars
            .Include(i => i.Image).ToListAsync();

        public async Task<Car> GetById(Guid id) => await context.Cars
           
            .Include(i => i.Image).FirstOrDefaultAsync(c => c.Id == id);
        public async Task Delete(Car obj)
        {
            entities.Remove(await GetById(obj.Id));
        }

        public async Task Insert(Car obj)
        {
            await entities.AddAsync(obj);
        }

        public async Task Update(Car obj)
        {
            context.Entry(await GetById(obj.Id)).CurrentValues.SetValues(obj);
        }
    }
}
