using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IMotorbikeRepository
    {
        Task<List<Vehicle>> GetAll();
        Task<Vehicle> GetById(Guid id);
        Task Insert(Vehicle obj);
        Task Update(Vehicle obj);
        Task Delete(Vehicle obj);
    }
}
