using AutoMapper;
using DAL.Data;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        //private readonly ILogger logger;

        public UnitOfWork(ApplicationDbContext context, IGenericRepository<Car> carRepo, IMediator mediator, IMapper mapper)
        {
            this.carRepo = carRepo;
            Context = context;
            this.Mediator = mediator;
            this.Mapper = mapper;
            //this.logger = logger;
        }
        public IGenericRepository<Car> carRepository
        {
            get { return carRepo ?? (carRepo = new GenericRepository<Car>(Context)); }
        }


        public IMediator Mediator { get; }

        public IMapper Mapper { get; }

        //public ILogger Logger { get; }
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
