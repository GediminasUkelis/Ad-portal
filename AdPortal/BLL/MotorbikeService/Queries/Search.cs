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
                var motorbikes = uow.Mediator.Send(new List.Query()).Result;

                if (motorbikes == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "no Motorbikes found");
                }

                if (request.obj.Manufacturer != null)
                {
                    motorbikes = motorbikes.Where(x => x.Manufacturer.Name == request.obj.Manufacturer.Name).ToList();
                }
                if (request.obj.Category != null)
                {
                    motorbikes = motorbikes.Where(x => x.Category.Name == request.obj.Category.Name).ToList();
                }
                if (request.obj.Condition != null)
                {
                    motorbikes = motorbikes.Where(x => x.Condition.VehicCondition == request.obj.Condition.VehicCondition).ToList();
                }
                if (request.obj.ManufactureDate != null)
                {
                    motorbikes = motorbikes.Where(x => x.ManufactureDate == request.obj.ManufactureDate).ToList();
                }
                if (request.obj.VehicleType != null)
                {
                    motorbikes = motorbikes.Where(x => x.VehicleType.Type == request.obj.VehicleType.Type).ToList();
                }
                if (request.obj.EngineCapacity != null)
                {
                    motorbikes = motorbikes.Where(x => x.EngineCapacity == request.obj.EngineCapacity).ToList();
                }
                if (request.obj.FuelType != null)
                {
                    motorbikes = motorbikes.Where(x => x.FuelType.Type == request.obj.FuelType.Type).ToList();
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
                    motorbikes = motorbikes.Where(x => x.Cooling.CoolingType == request.obj.Cooling.CoolingType).ToList();
                }
                if (request.obj.Defects != null)
                {
                    motorbikes = motorbikes.Where(x => x.Defects.Defect == request.obj.Defects.Defect).ToList();
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
                //foreach (PropertyInfo property in request.obj.GetType().GetProperties())
                //{
                //    if (property.PropertyType.IsClass)
                //    {
                //        list.Add(property.PropertyType);
                //    }
                //    else
                //    {
                //    list.Add(property);
                //    }
                //}


            }
            //private void ReadPropertiesRecursively(Type type)
            //{
            //    foreach (PropertyInfo property in type.GetProperties())
            //    {
            //        if (property.PropertyType.IsClass)
            //        {
            //            ReadPropertiesRecursively(property.PropertyType);
            //        }
            //        list.Add(property);
            //    }
            //}
        }
    }
}
