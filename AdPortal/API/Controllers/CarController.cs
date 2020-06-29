using AutoMapper;
using BLL.Features.CarService.Queries;
using BLL.Infastructure;
using BLL.Services.Interfaces;
using DAL.Repositories.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

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
        public async System.Threading.Tasks.Task<ActionResult<List<CarDto>>> ListAsync()
        {
            var result = await uow.Mediator.Send(new List.Query());
            return Ok(result);
            
        }

        [HttpGet("/api/Car/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async System.Threading.Tasks.Task<ActionResult<CarDto>> GetCarByIdAsync([FromRoute] Guid id)
        {

            return await uow.Mediator.Send(new GetById.Query(id));
        }

        [HttpPost]
        public ActionResult PostCar([FromBody] CarDto obj)
        {
            //carService.Insert(obj);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteCar(Guid id)
        {
          //  carService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateCar(CarDto obj)
        {
            //carService.Update(obj);
            return Ok();
        }
    }
}
