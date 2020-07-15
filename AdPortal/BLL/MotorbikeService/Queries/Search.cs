using BLL.Dto;
using BLL.Infastructure.Exceptions;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.Infastructure.Validation;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
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

            private readonly IUnitOfWork uow;
            public Handler(IUnitOfWork uow)
            {
                this.uow = uow;
            }

            public Task<List<MotorbikeDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                MotorbikeDtoValidator validator = new MotorbikeDtoValidator();
                ValidationResult results = validator.Validate(request.obj);

                if (!results.IsValid)
                {
                    validator.ValidateAndThrow(request.obj);
                }
             
                var motorbikes = uow.Mediator.Send(new List.Query());

                if (motorbikes == null)
                {
                    throw new StatusCodeException(HttpStatusCode.NotFound, "no Motorbikes found");
                }

              //ReadPropertiesRecursively(motorbikes.Result[1]);

                //foreach (var PropertyInfo in request.obj.GetType().GetProperties(BindingFlags.Public|BindingFlags.Instance))
                //{
                //    var asd = PropertyInfo.Name;
                //}

                if (request.obj.Manufacturer !=null)
                {

                }
                return motorbikes;
            }
            //private void ReadPropertiesRecursively(Type type)
            //{
            //    foreach ( PropertyInfo property in type.GetProperties())
            //    {
            //        if (property.PropertyType.IsClass)
            //        {
            //            ReadPropertiesRecursively(property.PropertyType);
            //        }
                    
            //    }
            //}
        }
    }
}
