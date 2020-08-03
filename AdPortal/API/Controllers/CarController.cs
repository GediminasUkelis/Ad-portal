using BLL.CarService.Commands;
using BLL.CarService.Queries;
using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web.Http.Controllers;
using Newtonsoft.Json;

namespace API.Controllers
{   
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    
    public class CarController : ControllerBase
    {
        private readonly IUnitOfWork uow;
        public CarController( IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CarDto>>> ListAsync()
        {
            return await uow.Mediator.Send(new List.Query());
        }
        
        [HttpGet("/api/Car/{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
    
        public async Task<ActionResult<CarDto>> GetCarByIdAsync([FromRoute] Guid id)
        {        
            return await uow.Mediator.Send(new GetById.Query(id));
        }

        [HttpGet("/api/Car/Search/{search}")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<List<CarDto>>> SearchCar([FromBody] CarDto obj)
        {
            return await uow.Mediator.Send(new Search.Query(obj));
        }

        [Authorize]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> PostCarAsync([FromForm] string obj, [FromForm] List<IFormFile> Image)
        {
            return await uow.Mediator.Send(new Insert.Command(obj,Image));
        }

        [Authorize]
        [HttpDelete("/api/Car/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> DeleteCarAsync([FromRoute] Guid id)
        {
            return await uow.Mediator.Send(new Delete.Command(id));
        }

        [Authorize]
        [HttpPut("/api/Car/{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> UpdateCarAsync([FromRoute]Guid Id,[FromBody]CarDto obj)
        {
            return await uow.Mediator.Send(new Put.Command(Id, obj));
        }
    }
}
