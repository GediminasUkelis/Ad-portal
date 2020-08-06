using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.MotorbikeService.Commands;
using BLL.MotorbikeService.Queries;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MotorbikeController : Controller
    {
        private readonly IUnitOfWork uow;

        public MotorbikeController(IUnitOfWork uow)
        {
            this.uow = uow;
        }
    
        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<MotorbikeDto>>> ListAsync()
        {
            return await uow.Mediator.Send(new List.Query());
        }
        
        [HttpGet("/api/Mototbike/{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<MotorbikeDto>> GetMotorbikeByIdAsync([FromRoute]Guid Id)
        {
            return await uow.Mediator.Send(new GetById.Query(Id));
        }

        [HttpGet("/api/Motorbike/Search")]
        [Consumes(MediaTypeNames.Application.Json)]
        public async Task<ActionResult<List<MotorbikeDto>>> SearchCar([FromBody] MotorbikeDto obj)
        {
            return await uow.Mediator.Send(new Search.Query(obj));
        }

        [Authorize]
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> PostMotorbikeAsync([FromForm] string obj, [FromForm] List<IFormFile> Image)
        {
            return await uow.Mediator.Send(new Insert.Command(obj, Image));
        }

        [Authorize]
        [HttpPut("/api/Motorbike/{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> PutMotorbikeAsync([FromBody] MotorbikeDto obj, [FromRoute] Guid Id)
        {
            return await uow.Mediator.Send(new Put.Command(obj, Id));
        }

        [Authorize]
        [HttpDelete("/api/Motorbike/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> DeleteMotorbikeAsync([FromRoute]Guid Id)
        {
            return await uow.Mediator.Send(new Delete.Command(Id));
        }
    }
}