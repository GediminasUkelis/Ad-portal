using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface ICarRepository
    {
        Task<List<Vehicle>> GetAll();
        Task<Vehicle> GetById(Guid id);
        Task Insert(Vehicle obj);
        Task Update(Vehicle obj);
        Task Delete(Vehicle obj);
    }
}
