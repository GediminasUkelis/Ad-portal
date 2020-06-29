using DAL.Data;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ApplicationDbContext Context { get; }
        IGenericRepository<Car> carRepository { get; }
        void Commit();
    }
}
