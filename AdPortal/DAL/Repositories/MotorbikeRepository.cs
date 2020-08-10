using DAL.Data;
using DAL.Repositories.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class MotorbikeRepository : IMotorbikeRepository
    {
        private ApplicationDbContext context;
        private DbSet<Motorbike> entities;

        public MotorbikeRepository(ApplicationDbContext _context)
        {

            context = _context;
            entities = context.Set<Motorbike>();
        }
        public async Task<List<Motorbike>> GetAll() => await context.Motorbikes
            .Include(i => i.Image).ToListAsync();

        public async Task<Motorbike> GetById(Guid id) => await context.Motorbikes
            .Include(i => i.Image).FirstOrDefaultAsync(c => c.Id == id);
        public async Task Delete(Motorbike obj)
        {
            entities.Remove(await GetById(obj.Id));
        }

        public async Task Insert(Motorbike obj)
        {
            await entities.AddAsync(obj);
        }

        public async Task Update(Motorbike obj)
        {
            context.Entry(await GetById(obj.Id)).CurrentValues.SetValues(obj);
        }
    }
}
