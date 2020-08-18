using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using FluentValidation;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.MotorbikeService.Queries
{
    public class Search
    {
        public class Query : IRequest<List<VehicleDto>>
        {
            public VehicleDto obj { get; set; }
            public Query(VehicleDto obj)
            {
                this.obj = obj;
            }
        }
        public class Handler : IRequestHandler<Query, List<VehicleDto>>
        {
            public List<object> list = new List<object>();
            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow;
            }

            public async Task<List<VehicleDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var motorbikes = await uow.Mediator.Send(new List.Query());

                if (motorbikes == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "no Motorbikes found");
                }

                if (request.obj.Manufacturer != null)
                {
                    motorbikes = motorbikes.Where(x => x.Manufacturer == request.obj.Manufacturer).ToList();
                }
                if (request.obj.ManufacturerModel != null)
                {
                    motorbikes = motorbikes.Where(x => x.ManufacturerModel == request.obj.ManufacturerModel).ToList();
                }
                if (request.obj.ManufactureDate != null)
                {
                    motorbikes = motorbikes.Where(x => x.ManufactureDate == request.obj.ManufactureDate).ToList();
                }
                if (request.obj.Registration != false)
                {
                    motorbikes = motorbikes.Where(x => x.Registration == request.obj.Registration).ToList();
                }
                if (request.obj.Engine != null)
                {
                    motorbikes = motorbikes.Where(x => x.Engine == request.obj.Engine).ToList();
                }
                if (request.obj.Category != null)
                {
                    motorbikes = motorbikes.Where(x => x.Category == request.obj.Category).ToList();
                }
                if (request.obj.Frame != null)
                {
                    motorbikes = motorbikes.Where(x => x.Frame == request.obj.Frame).ToList();
                }
                if (request.obj.Fuel != null)
                {
                    motorbikes = motorbikes.Where(x => x.Fuel == request.obj.Fuel).ToList();
                }
                if (request.obj.Cooling != null)
                {
                    motorbikes = motorbikes.Where(x => x.Cooling == request.obj.Cooling).ToList();
                }
                if (request.obj.Transmission != null)
                {
                    motorbikes = motorbikes.Where(x => x.Transmission == request.obj.Transmission).ToList();
                }
                if (request.obj.Color != null)
                {
                    motorbikes = motorbikes.Where(x => x.Color == request.obj.Color).ToList();
                }
                if (request.obj.VehicleInspection != null)
                {
                    motorbikes = motorbikes.Where(x => x.VehicleInspection== request.obj.VehicleInspection).ToList();
                }
                if (request.obj.TireWearOut != null)
                {
                    motorbikes = motorbikes.Where(x => x.TireWearOut == request.obj.TireWearOut).ToList();
                }
                if (request.obj.Power != null)
                {
                    motorbikes = motorbikes.Where(x => x.Power == request.obj.Power).ToList();
                }
                if (request.obj.Price != null)
                {
                    motorbikes = motorbikes.Where(x => x.Price == request.obj.Price).ToList();
                }
                if (request.obj.Condition != null)
                {
                    motorbikes = motorbikes.Where(x => x.Condition == request.obj.Condition).ToList();
                }
                if (request.obj.CarDetails != null)
                {
                    if (request.obj.CarDetails.SteeringWheelPos != null)
                    {
                        motorbikes = motorbikes.Where(x => x.CarDetails.SteeringWheelPos == request.obj.CarDetails.SteeringWheelPos).ToList();
                    }
                    if (request.obj.CarDetails.Seats != null)
                    {
                        motorbikes = motorbikes.Where(x => x.CarDetails.Seats == request.obj.CarDetails.Seats).ToList();
                    }
                    if (request.obj.CarDetails.Doors != null)
                    {
                        motorbikes = motorbikes.Where(x => x.CarDetails.Doors == request.obj.CarDetails.Doors).ToList();
                    }
                }
                return motorbikes;
            }
        }
    }
}
