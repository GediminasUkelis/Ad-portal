using BLL.CarService.Commands;
using BLL.CarService.Queries;
using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading.Tasks;

namespace API.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
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

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> PostCarAsync([FromBody] CarDto obj)
        {
            return await uow.Mediator.Send(new Insert.Command(obj));
        }
        [HttpDelete("/api/Car/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> DeleteCarAsync([FromRoute] Guid id)
        {
            return await uow.Mediator.Send(new Delete.Command(id));
        }

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
