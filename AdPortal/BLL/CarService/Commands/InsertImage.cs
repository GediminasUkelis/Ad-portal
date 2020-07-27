using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using Domain.Models;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BLL.CarService.Commands
{
    public class InsertImage
    {

        public class Command : IRequest
        {
            public Command(List<IFormFile> obj)
            {
                this.obj = obj;
            }
            public List<IFormFile> obj { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow ?? throw new ArgumentNullException(nameof(uow));
            }



            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {

                foreach (var Image in request.obj)
                {
                    IFormFileValidation validator = new IFormFileValidation();
                    ValidationResult results = validator.Validate(Image);
                    if (!results.IsValid)
                    {
                        validator.ValidateAndThrow(Image);
                    }
                }




                var obj = uow.Mapper.Map<Image>(request.obj);
                uow.ImageRepository.Insert(obj);
                uow.Commit();
                return Unit.Value;
            }
        }


    }
}
