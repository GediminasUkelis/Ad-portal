using AutoMapper;
using BLL.Infastructure.UnitOfWork.Interface;
using DAL.Data;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure.UnitOfWork
{
    public class UnitOfWork 
    {

        public ApplicationDbContext Context { get; }
        private IGenericRepository<Car> carRepo;
       

        public UnitOfWork(ApplicationDbContext context, IGenericRepository<Car> carRepo, IMediator mediator, IMapper mapper, ILogger logger)
        {
            this.carRepo = carRepo;
            Context = context;
            this.Mediator = mediator;
            this.Mapper = mapper;
            this.Logger = logger;
        }
        public IGenericRepository<Car> carRepository
        {
            get { return carRepo ?? (carRepo = new GenericRepository<Car>(Context)); }
        }


        public IMediator Mediator { get; }

        public IMapper Mapper { get; }

        public ILogger Logger { get; }


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
