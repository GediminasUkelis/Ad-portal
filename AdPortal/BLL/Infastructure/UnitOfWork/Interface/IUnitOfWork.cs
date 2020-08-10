using AutoMapper;
using DAL.Data;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Infastructure.UnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationDbContext Context { get; }
        IMediator Mediator { get; }
        IMapper Mapper { get; }
        ICarRepository CarRepository { get; }
        IMotorbikeRepository MotorbikeRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        IGenericRepository<Image> ImageRepository { get; }
        IUserService User { get; }
        IHttpContextAccessor httpContextAccessor { get; }
        ILogger<UnitOfWork> Logger { get; }
        void Commit();
    }
}
