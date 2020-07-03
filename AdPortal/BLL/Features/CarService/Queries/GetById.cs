using AutoMapper;
using BLL.Dto;
using BLL.Infastructure;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.ModelBinding;

namespace BLL.Features.CarService.Queries
{
    public class GetById
    {
        public class Query : IRequest<CarDto>
        {
            public Query(Guid Id)
            {
                this.Id = Id;
            }
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, CarDto>
        {
            private readonly IUnitOfWork uow;

            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }
            public async Task<CarDto> Handle(Query request, CancellationToken cancellationToken)
            {
               var DbEntry = uow.carRepository.GetById(request.Id);
                if (DbEntry == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound,"was not found in database", request.Id);

                }
                var DbEntryDto = uow.Mapper.Map<CarDto>(DbEntry);
                    return DbEntryDto;
                
            }
        }
    }
}
