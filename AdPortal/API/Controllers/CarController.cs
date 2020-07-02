using API.Middleware;
using AutoMapper;
using BLL.Dto;
using BLL.Features.CarService.Commands;
using BLL.Features.CarService.Queries;
using BLL.Infastructure;
using BLL.Infastructure.UnitOfWork.Interface;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace API.Controllers
{
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CarDto>>> ListAsync()
        {
            return await uow.Mediator.Send(new List.Query());
        }

        [HttpGet("/api/Car/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CarDto>> GetCarByIdAsync([FromRoute] Guid id)
        {        
            return await uow.Mediator.Send(new GetById.Query(id));
        }

        [HttpPost]
        public async Task<Unit> PostCarAsync([FromBody] CarDto obj)
        {

            return await uow.Mediator.Send(new Insert.Command(obj));
        }
        [HttpDelete("/api/Car/{id}")]
        public async Task<Unit> DeleteCarAsync([FromRoute] Guid id)
        {
            return await uow.Mediator.Send(new Delete.Command(id));
        }

        [HttpPut]
        public async Task<Unit> UpdateCarAsync(CarDto obj)
        {
            return await uow.Mediator.Send(new Put.Command(obj));
        }
    }
}
