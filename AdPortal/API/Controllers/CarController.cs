using AutoMapper;
using BLL.Features.CarService.Queries;
using BLL.Infastructure;
using BLL.Services.Interfaces;
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
        private readonly IMapper mapper;
        private IGenericService<CarDto> carService;
        private readonly IMediator mediator;
        public CarController(IGenericService<CarDto> carService, IMapper mapper, IMediator mediator)
        {
            this.carService = carService;
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async System.Threading.Tasks.Task<ActionResult<List<CarDto>>> ListAsync()
        {
            var result = await mediator.Send(new List.Query());
            return Ok(result);
            //var DbEntry = carService.GetAll();
     
            //if (DbEntry == null)
            //{
            //    return NotFound(); 
            //}
            //return Ok(DbEntry);
        
            //return unitOfWork.mediator.Send(new List.Query());
        }

        [HttpGet("/api/Car/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async System.Threading.Tasks.Task<ActionResult<CarDto>> GetCarByIdAsync([FromRoute] Guid id)
        {

            return await mediator.Send(new GetById.Query(id));
        }

        [HttpPost]
        public ActionResult PostCar([FromBody] CarDto obj)
        {
            carService.Insert(obj);
            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteCar(Guid id)
        {
            carService.Delete(id);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateCar(CarDto obj)
        {
            carService.Update(obj);
            return Ok();
        }
    }
}
