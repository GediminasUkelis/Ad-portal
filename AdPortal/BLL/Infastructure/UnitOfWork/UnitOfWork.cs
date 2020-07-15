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
    public class UnitOfWork : IUnitOfWork
    {

        public ApplicationDbContext Context { get; }
        private IGenericRepository<Car> carRepo;
        private IGenericRepository<Tire> TireRepo;
        private IGenericRepository<Motorbike> MotorbikeRepo;

        public UnitOfWork(ApplicationDbContext context, IGenericRepository<Car> carRepo,
            IMediator mediator, IMapper mapper, ILogger<UnitOfWork> logger,
            IGenericRepository<Tire> TireRepo, IGenericRepository<Motorbike> motorbikeRepo)
        {
            this.carRepo = carRepo;
            Context = context;
            this.Mediator = mediator;
            this.Mapper = mapper;
            this.Logger = logger;
            this.TireRepo = TireRepo;
            this.MotorbikeRepo = motorbikeRepo;
        }
        public IGenericRepository<Car> CarRepository
        {
            get { return carRepo ?? (carRepo = new GenericRepository<Car>(Context)); }
        }
        public IGenericRepository<Tire> TireRepository
        {
            get { return TireRepo ?? (TireRepo = new GenericRepository<Tire>(Context)); }
        }
        public IGenericRepository<Motorbike> MotorbikeRepository {

            get { return MotorbikeRepo ?? (MotorbikeRepo = new GenericRepository<Motorbike>(Context)); }
        }
    
        public IMediator Mediator { get; }

        public IMapper Mapper { get; }

        public ILogger<UnitOfWork> Logger { get; }


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
