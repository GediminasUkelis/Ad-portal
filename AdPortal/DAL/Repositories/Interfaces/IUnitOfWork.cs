using AutoMapper;
using DAL.Data;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationDbContext Context { get; }
        IMediator Mediator { get; }
        IMapper Mapper { get; }
        IGenericRepository<Car> carRepository { get; }
        ILogger Logger { get; }
        void Commit();
    }
}
