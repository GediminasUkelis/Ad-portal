using AutoMapper;
using BLL.Infastructure;
using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BLL.Services
{
    public class CarService : IGenericService<CarDto>
    {
        private readonly IMapper mapper;
        private IGenericRepository<Car> CarRepository;

        public CarService(IGenericRepository<Car> _CarRepository, IMapper mapper)
        {
            CarRepository = _CarRepository;
            this.mapper = mapper;
        }

        public void Delete(Guid id)
        {
            var dbEntry = CarRepository.GetById(id);
            CarRepository.Delete(dbEntry);
        }

        public List<CarDto> GetAll()
        {
            List<CarDto> carDtos = new List<CarDto>();
            var DbEntry = CarRepository.GetAll();
            foreach(var item in DbEntry)
            {
                carDtos.Add(mapper.Map<CarDto>(item));

            }
            
            return carDtos;
        }

        public CarDto GetById(Guid id)
        {

            var entry = CarRepository.GetById(id);
            if (entry == null)
            {
                return null;
            }
            var DtoObject = mapper.Map<CarDto>(entry);
            return DtoObject;
        }

        public void Insert(CarDto obj)
        {
          
            var DtoObject = mapper.Map<Car>(obj);
            CarRepository.Insert(DtoObject);
        }

        public void Update(CarDto obj)
        {
            var DtoObject = mapper.Map<Car>(obj);
            CarRepository.Update(DtoObject);
        }

    }
}
