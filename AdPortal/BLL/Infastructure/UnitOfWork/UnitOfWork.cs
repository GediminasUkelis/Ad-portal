using AutoMapper;
using BLL.Infastructure.UnitOfWork.Interface;
using DAL.Data;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
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
        private IGenericRepository<Image> ImageRepo;
        private IGenericRepository<User> UserRepo;
        private IUserService userService;
        private IHttpContextAccessor httpContext;
        public UnitOfWork(ApplicationDbContext context, IGenericRepository<Car> carRepo,
            IMediator mediator, IMapper mapper, ILogger<UnitOfWork> logger,
            IGenericRepository<Tire> TireRepo, IGenericRepository<Motorbike> motorbikeRepo, IUserService userService,
            IHttpContextAccessor httpContext, IGenericRepository<Image> ImageRepo, IGenericRepository<User> UserRepo)
        {
            this.UserRepo = UserRepo;
            this.carRepo = carRepo;
            Context = context;
            this.Mediator = mediator;
            this.Mapper = mapper;
            this.Logger = logger;
            this.TireRepo = TireRepo;
            this.MotorbikeRepo = motorbikeRepo;
            this.ImageRepo = ImageRepo;
            this.userService = userService;
            this.httpContext = httpContext;
        }
        public IGenericRepository<Car> CarRepository
        {
            get { return carRepo ?? (carRepo = new GenericRepository<Car>(Context)); }
        }
        public IGenericRepository<Tire> TireRepository
        {
            get { return TireRepo ?? (TireRepo = new GenericRepository<Tire>(Context)); }
        }
        public IGenericRepository<Motorbike> MotorbikeRepository
        {

            get { return MotorbikeRepo ?? (MotorbikeRepo = new GenericRepository<Motorbike>(Context)); }
        }
        public IGenericRepository<Image> ImageRepository
        { 
            get { return ImageRepo ?? (ImageRepo = new GenericRepository<Image>(Context)); }
        }
        public IGenericRepository<User> UserRepository
        {
            get { return UserRepo ?? (UserRepo = new GenericRepository<User>(Context)); }
        }
        public IMediator Mediator { get; }

        public IMapper Mapper { get; }

        public ILogger<UnitOfWork> Logger { get; }

        public IUserService User
        {
            get { return userService ?? (userService = new UserService(Context)); }
        }

        public IHttpContextAccessor httpContextAccessor
        {
            get { return httpContext ?? (httpContext = new HttpContextAccessor()); }
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
