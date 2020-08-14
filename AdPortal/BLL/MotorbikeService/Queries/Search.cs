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
        public class Query : IRequest<List<MotorbikeDto>>
        {
            public MotorbikeDto obj { get; set; }
            public Query(MotorbikeDto obj)
            {
                this.obj = obj;
            }
        }
        public class Handler : IRequestHandler<Query, List<MotorbikeDto>>
        {
            public List<object> list = new List<object>();
            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow;
            }

            public async Task<List<MotorbikeDto>> Handle(Query request, CancellationToken cancellationToken)
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
                if (request.obj.Category != null)
                {
                    motorbikes = motorbikes.Where(x => x.Category == request.obj.Category).ToList();
                }
                if (request.obj.Condition != null)
                {
                    motorbikes = motorbikes.Where(x => x.Condition == request.obj.Condition).ToList();
                }
                if (request.obj.ManufactureDate != null)
                {
                    motorbikes = motorbikes.Where(x => x.ManufactureDate == request.obj.ManufactureDate).ToList();
                }
                if (request.obj.BikeType != null)
                {
                    motorbikes = motorbikes.Where(x => x.BikeType == request.obj.BikeType).ToList();
                }
                if (request.obj.EngineCapacity != null)
                {
                    motorbikes = motorbikes.Where(x => x.EngineCapacity == request.obj.EngineCapacity).ToList();
                }
                if (request.obj.Fuel != null)
                {
                    motorbikes = motorbikes.Where(x => x.Fuel == request.obj.Fuel).ToList();
                }
                if (request.obj.TireWearOut != 0)
                {
                    motorbikes = motorbikes.Where(x => x.TireWearOut == request.obj.TireWearOut).ToList();
                }
                if (request.obj.Power != null)
                {
                    motorbikes = motorbikes.Where(x => x.Power == request.obj.Power).ToList();
                }
                if (request.obj.Cooling != null)
                {
                    motorbikes = motorbikes.Where(x => x.Cooling == request.obj.Cooling).ToList();
                }
                if (request.obj.Defects != null)
                {
                    motorbikes = motorbikes.Where(x => x.Defects == request.obj.Defects).ToList();
                }
                if (request.obj.Registration != false)
                {
                    motorbikes = motorbikes.Where(x => x.Registration == request.obj.Registration).ToList();
                }
                if (request.obj.Description != null)
                {
                    motorbikes = motorbikes.Where(x => x.Description == request.obj.Description).ToList();
                }
                if (request.obj.Price != null)
                {
                    motorbikes = motorbikes.Where(x => x.Price == request.obj.Price).ToList();
                }
                return motorbikes;
     

            }
         
        }
    }
}
