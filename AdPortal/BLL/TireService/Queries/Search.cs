using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.TireService.Queries
{
    public class Search
    {
        public class Query : IRequest<List<TireDto>>
        {
            public TireDto obj { get; set; }
            public Query(TireDto obj)
            {
                this.obj = obj;
            }
        }
        public class Handler : IRequestHandler<Query, List<TireDto>>
        {
            // public List<object> list = new List<object>();
            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow;
            }

            public async Task<List<TireDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                var tires = uow.Mediator.Send(new List.Query()).Result;

                if (tires == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "no Motorbikes found");
                }

                if (request.obj.Condition != null)
                {

                    tires = tires.Where(x => x.Condition.VehicCondition == request.obj.Condition.VehicCondition).ToList();
                }
                if (request.obj.Description != null)
                {
                    tires = tires.Where(x => x.Description == request.obj.Description).ToList();
                }
                if (request.obj.Diameter != null)
                {
                    tires = tires.Where(x => x.Diameter.TireDiameter == request.obj.Diameter.TireDiameter).ToList();
                }
                if (request.obj.Height != null)
                {
                    tires = tires.Where(x => x.Height.TireHeight == request.obj.Height.TireHeight).ToList();
                }
                if (request.obj.ManufactureDate != null)
                {
                    tires = tires.Where(x => x.ManufactureDate == request.obj.ManufactureDate).ToList();
                }
                if (request.obj.Manufacturer != null)
                {
                    tires = tires.Where(x => x.Manufacturer.Name == request.obj.Manufacturer.Name).ToList();
                }
                if (request.obj.Price != 0)
                {
                    tires = tires.Where(x => x.Price == request.obj.Price).ToList();
                }
                if (request.obj.Quantity != 0)
                {
                    tires = tires.Where(x => x.Quantity == request.obj.Quantity).ToList();
                }
                if (request.obj.Season != null)
                {
                    tires = tires.Where(x => x.Season.SeasonName == request.obj.Season.SeasonName).ToList();
                }
                if (request.obj.TirePurpose != null)
                {
                    tires = tires.Where(x => x.TirePurpose.Name == request.obj.TirePurpose.Name).ToList();
                }
                if (request.obj.TireWearOut != 0)
                {
                    tires = tires.Where(x => x.TireWearOut == request.obj.TireWearOut).ToList();
                }
                if (request.obj.Width != null)
                {
                    tires = tires.Where(x => x.Width.TireWidth == request.obj.Width.TireWidth).ToList();
                }

                return tires;
            }
        }
    }
}
