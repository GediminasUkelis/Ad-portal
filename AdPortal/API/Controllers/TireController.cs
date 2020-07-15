using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using BLL.Dto;
using BLL.Infastructure.UnitOfWork.Interface;
using BLL.TireService.Commands;
using BLL.TireService.Queries;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class TireController : Controller
    {
        private readonly IUnitOfWork uow;
        public TireController(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<TireDto>>> ListAsync()
        {
            return await uow.Mediator.Send(new List.Query());
        }

        [HttpGet("/api/Tire/{id}")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TireDto>> GetTireByIdAsync([FromRoute] Guid id)
        {
            return await uow.Mediator.Send(new GetById.Query(id));
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> PostTireAsync([FromBody] TireDto obj)
        {
            return await uow.Mediator.Send(new Insert.Command(obj));
        }
        [HttpDelete("/api/Tire/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> DeleteTireAsync([FromRoute] Guid id)
        {
            return await uow.Mediator.Send(new Delete.Command(id));
        }

        [HttpPut("/api/Tire/{id}")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Unit> UpdateTireAsync([FromRoute] Guid Id, [FromBody] TireDto obj)
        {
            return await uow.Mediator.Send(new Put.Command(Id, obj));
        }
    }
}
