using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.CarService.Queries
{
    public class Search
    {
        public class Query : IRequest<List<CarDto>>
        {
            public Query( CarDto obj)
            {
                this.obj = obj;
                
            }
            public CarDto obj { get; set; }
        }
        public class Handler : IRequestHandler<Query, List<CarDto>>
        {
            private readonly IUnitOfWork uow;

            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<List<CarDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var cars = uow.Mediator.Send(new List.Query()).Result;

                if (cars == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "no Motorbikes found");
                }

                if (request.obj.Manufacturer != null)
                {
                    cars = cars.Where(x => x.Manufacturer.Name == request.obj.Manufacturer.Name).ToList();
                }
                if (request.obj.Category != null)
                {
                    cars = cars.Where(x => x.Category.Name == request.obj.Category.Name).ToList();
                }
                if (request.obj.Category != null)
                {
                    cars = cars.Where(x => x.Category.Name == request.obj.Category.Name).ToList();
                }
                if (request.obj.ManufactureDate != null)
                {
                    cars = cars.Where(x => x.ManufactureDate == request.obj.ManufactureDate).ToList();
                }
                if (request.obj.Color != null)
                {
                    cars = cars.Where(x => x.Color.Name == request.obj.Color.Name).ToList();
                }
                if (request.obj.Doors != null)
                {
                    cars = cars.Where(x => x.Doors.DoorCount == request.obj.Doors.DoorCount).ToList();
                }
                if (request.obj.FuelType != null)
                {
                    cars = cars.Where(x => x.FuelType.Type == request.obj.FuelType.Type).ToList();
                }
                if (request.obj.Engine != null)
                {
                    cars = cars.Where(x => x.Engine == request.obj.Engine).ToList();
                }
                if (request.obj.FrameType != null)
                {
                    cars = cars.Where(x => x.FrameType.Type == request.obj.FrameType.Type).ToList();
                }
                if (request.obj.ManufacturerModel != null)
                {
                    cars = cars.Where(x => x.ManufacturerModel.Name == request.obj.ManufacturerModel.Name).ToList();
                }
                if (request.obj.Defects != null)
                {
                    cars = cars.Where(x => x.Defects.Defect == request.obj.Defects.Defect).ToList();
                }
                if (request.obj.Seats != 0)
                {
                    cars = cars.Where(x => x.Seats == request.obj.Seats).ToList();
                }
                if (request.obj.Description != null)
                {
                    cars = cars.Where(x => x.Description == request.obj.Description).ToList();
                }
                if (request.obj.Price != 0)
                {
                    cars = cars.Where(x => x.Price == request.obj.Price).ToList();
                }
                if (request.obj.SteeringWheelPos != null)
                {
                    cars = cars.Where(x => x.SteeringWheelPos.Position == request.obj.SteeringWheelPos.Position).ToList();
                }
                if (request.obj.Transmission != null)
                {
                    cars = cars.Where(x => x.Transmission.Type == request.obj.Transmission.Type).ToList();
                }
                
                return cars;

            }
        }
    }
}
