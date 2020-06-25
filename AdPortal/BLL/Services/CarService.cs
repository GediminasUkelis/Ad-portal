using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public class CarService : IGenericService<Car>
    {
        private IGenericRepository<Car> CarRepository;

        public CarService(IGenericRepository<Car> _CarRepository)
        {
            CarRepository = _CarRepository;
        }

        public void Delete(Guid id)
        {
            var dbEntry = CarRepository.GetById(id);
            CarRepository.Delete(dbEntry);
        }

        public List<Car> GetAll()
        {
            
            return CarRepository.GetAll();
        }

        public Car GetById(Guid id)
        {
            
            var entry = CarRepository.GetById(id);
            if (entry == null)
            {
                return null;
            }
            return entry;
        }

        public void Insert(Car obj)
        {
            CarRepository.Insert(obj);
        }

        public void Update(Car obj)
        {
            CarRepository.Update(obj);
        }

    }
}
