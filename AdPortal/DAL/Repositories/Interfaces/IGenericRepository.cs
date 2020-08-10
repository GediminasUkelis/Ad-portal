using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseModel
    {
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task Insert(T obj);
        Task Update(T obj);
        Task Delete(T obj);
    }
}
