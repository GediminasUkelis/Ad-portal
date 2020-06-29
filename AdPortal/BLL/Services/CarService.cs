using AutoMapper;
using BLL.Infastructure;
using BLL.Services.Interfaces;
using DAL.Extensions;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BLL.Services
{
    public class CarService : IGenericService<CarDto>
    {
        private readonly IMapper mapper;
        private IGenericRepository<Car> CarRepository;
        private readonly IMediator mediator;
        private readonly IUnitOfWork uow;
        public CarService(IGenericRepository<Car> CarRepository, IMapper mapper, IMediator mediator, IUnitOfWork uow)
        {
            this.CarRepository = CarRepository;
            this.mapper = mapper;
            this.uow = uow;
            this.mediator = mediator;
        }

        public void Delete(Guid id)
        {
            var dbEntry = CarRepository.GetById(id);
            CarRepository.Delete(dbEntry);
            uow.Commit();
        }

        public List<CarDto> GetAll()
        {
            List<CarDto> carDtos = new List<CarDto>();
            var includes = new Includes<Car>(query =>
            {
                return query.Include(b => b.Manufacturer)
                                .ThenInclude(a => a.manufacturerModels)
                            .Include(c => c.SteeringWheelPos)
                            .Include(x => x.Transmission)
                            .Include(a => a.Category)
                            .Include(s => s.Color)
                            .Include(d => d.Defects)
                            .Include(f => f.Doors)
                            .Include(q => q.FrameType)
                            .Include(w => w.FuelType)
                            .Include(e => e.CarFeatures)
                                .ThenInclude(y => y.Feature);
                                
                
            });

            var DbEntry = uow.carRepository.GetAll(includes.Expression);
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
