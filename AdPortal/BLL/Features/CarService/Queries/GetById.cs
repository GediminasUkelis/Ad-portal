using AutoMapper;
using BLL.Infastructure;
using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                    return null;
                }
                var DbEntryDto = uow.Mapper.Map<CarDto>(DbEntry);
                return DbEntryDto;
            }
        }
    }
}
