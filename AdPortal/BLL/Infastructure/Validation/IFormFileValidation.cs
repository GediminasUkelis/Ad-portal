using BLL.Dto;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BLL.Infastructure.Validation
{
    public class IFormFileValidation: AbstractValidator<IFormFile>
    {
        public IFormFileValidation()
        {
            RuleFor(x => x).NotEmpty().WithMessage("Image was not uploaded");
            //When(x => x != null, () =>
            //{
            //    RuleFor(x => x.Name).NotEmpty().WithMessage("Image was not uploaded");
            //});
        }
    }
}
