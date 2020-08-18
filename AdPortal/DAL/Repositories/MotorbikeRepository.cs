﻿using DAL.Data;
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
        private DbSet<Vehicle> entities;

        public MotorbikeRepository(ApplicationDbContext _context)
        {

            context = _context;
            entities = context.Set<Vehicle>();
        }
        public async Task<List<Vehicle>> GetAll() => await context.Vehicles
            .Include(i => i.Image).Include(m=>m.BikeDetails).ToListAsync();

        public async Task<Vehicle> GetById(Guid id) => await context.Vehicles
            .Include(i => i.Image).Include(m => m.BikeDetails).FirstOrDefaultAsync(c => c.Id == id);
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
            context.Entry(await GetById(obj.Id)).CurrentValues.SetValues(obj);
        }
    }
}
