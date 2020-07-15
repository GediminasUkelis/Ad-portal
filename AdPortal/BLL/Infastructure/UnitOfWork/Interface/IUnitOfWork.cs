using AutoMapper;
using DAL.Data;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
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
        IGenericRepository<Car> CarRepository { get; }
        IGenericRepository<Tire> TireRepository { get; }
        IGenericRepository<Motorbike> MotorbikeRepository { get; }

        ILogger<UnitOfWork> Logger { get; }
        void Commit();
    }
}
