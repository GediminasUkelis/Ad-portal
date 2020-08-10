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
        private ICarRepository carRepo;
     
        private IMotorbikeRepository MotorbikeRepo;
        private IGenericRepository<Image> ImageRepo;
        private IGenericRepository<User> UserRepo;
        private IUserService userService;
        private IHttpContextAccessor httpContext;
        public UnitOfWork(ApplicationDbContext context, ICarRepository carRepo,
            IMediator mediator, IMapper mapper, ILogger<UnitOfWork> logger,
            IMotorbikeRepository motorbikeRepo, IUserService userService,
            IHttpContextAccessor httpContext, IGenericRepository<User> UserRepo, IGenericRepository<Image> ImageRepo)
        {
            this.UserRepo = UserRepo;
            this.carRepo = carRepo;
            Context = context;
            this.ImageRepo = ImageRepo;
            this.Mediator = mediator;
            this.Mapper = mapper;
            this.Logger = logger;
           
            this.MotorbikeRepo = motorbikeRepo;
  
            this.userService = userService;
            this.httpContext = httpContext;
        }
        public ICarRepository CarRepository
        {
            get { return carRepo ??= new CarRepository(Context); }
        }
       
        public IMotorbikeRepository MotorbikeRepository
        {

            get { return MotorbikeRepo ??= new MotorbikeRepository(Context); }
        }
    
        public IGenericRepository<User> UserRepository
        {
            get { return UserRepo ??= new GenericRepository<User>(Context); }
        }
        public IGenericRepository<Image> ImageRepository
        {
            get { return ImageRepo ??= new GenericRepository<Image>(Context); }
        }
        public IMediator Mediator { get; }

        public IMapper Mapper { get; }

        public ILogger<UnitOfWork> Logger { get; }

        public IUserService User
        {
            get { return userService ??= new UserService(Context); }
        }

        public IHttpContextAccessor httpContextAccessor
        {
            get { return httpContext ??= new HttpContextAccessor(); }
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
