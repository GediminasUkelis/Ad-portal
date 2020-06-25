using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services.Interfaces
{
    public interface IGenericService<T> 
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(Guid id);
    }
}
