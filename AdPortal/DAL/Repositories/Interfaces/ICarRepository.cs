using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface ICarRepository
    {
        Task<List<Car>> GetAll();
        Task<Car> GetById(Guid id);
        Task Insert(Car obj);
        Task Update(Car obj);
        Task Delete(Car obj);
    }
}
