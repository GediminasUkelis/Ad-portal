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
            public Query( decimal? price, string? category)
            {
               
                this.price = price;
                cat = new Category
                {
                    Name = category
                };
            }
            public Category? cat { get; set; }
            public decimal? price { get; set; }
            
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
                

                if(request.cat.Name!=null)
                {
                    cars = cars.Where(x => x.Category.Name == request.cat.Name).ToList();    
                }
                if(request.price!=null)
                {
                    cars = cars.Where(x => x.Price==request.price).ToList();
                }
              
                if (cars.Count==0)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, $"No cars were found in database");

                }
             
                return cars;

            }
        }
    }
}
