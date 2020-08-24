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
        private DbSet<Vehicle> entities;

        public CarRepository(ApplicationDbContext _context)
        {
            context = _context;
            entities = context.Set<Vehicle>();
        }
        public async Task<List<Vehicle>> GetAll() => await context.Vehicles
            .Include(i => i.Image).Include(c=>c.CarDetails).Where(x=>x.CarDetails!=null).ToListAsync();

        public async Task<Vehicle> GetById(Guid id) => await context.Vehicles

            .Include(i => i.Image).Include(c => c.CarDetails).FirstOrDefaultAsync(c => c.Id == id&&c.CarDetails!=null);
        public async Task Delete(Vehicle obj)
        {
            entities.Remove(await GetById(obj.Id));
        }

        public async Task Insert(Vehicle obj)
        {
            await entities.AddAsync(obj);
        }

        public async Task Update(Vehicle obj)
        {
            context.Vehicles.Update(obj);

        }
    }
}
