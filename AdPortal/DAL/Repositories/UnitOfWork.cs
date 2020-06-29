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
    public class UnitOfWork : IUnitOfWork
    {
        public ApplicationDbContext Context { get; }
        private IGenericRepository<Car> carRepo;
        

        public UnitOfWork(ApplicationDbContext context, IGenericRepository<Car> carRepo)
        {
            this.carRepo = carRepo;
            Context = context;
        }
        public IGenericRepository<Car> carRepository
        {
            get { return carRepo ?? (carRepo = new GenericRepository<Car>(Context)); }
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();

        }
    }
}
