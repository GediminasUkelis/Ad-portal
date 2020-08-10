using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IMotorbikeRepository
    {
        Task<List<Motorbike>> GetAll();
        Task<Motorbike> GetById(Guid id);
        Task Insert(Motorbike obj);
        Task Update(Motorbike obj);
        Task Delete(Motorbike obj);
    }
}
