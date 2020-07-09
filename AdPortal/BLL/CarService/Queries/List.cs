﻿using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.CarService.Queries
{
    public class List
    {
        public class Query : IRequest<List<CarDto>>
        {
            public Query()
            {

            }
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
                List<CarDto> carDtos = new List<CarDto>();
                var DbEntry = uow.carRepository.GetAll();

                foreach (var item in DbEntry)
                {
                    carDtos.Add(uow.Mapper.Map<CarDto>(item));
                }
                return carDtos;
            }
        }
    }
}