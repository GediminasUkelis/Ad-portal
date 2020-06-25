using BLL.CarService;
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
        private IGenericService<Car> carService;
        public CarController(IGenericService<Car> carService)
        {
            this.carService = carService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Unit>> List()
        {
            var DbEntry = carService.GetAll();
            if (DbEntry == null)
            {
                return NotFound();
            }
            return Ok(DbEntry);
            //return unitOfWork.mediator.Send(new List.Query());
        }

        [HttpGet("/api/Car/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Car> GetCarById([FromRoute] Guid id)
        {
            var asd = carService.GetById(id);
            if(asd==null)
            {
                return NotFound();
            }
            return Ok(asd);
        }

        [HttpPost]
        public ActionResult PostCar([FromBody] Car obj)
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
        public ActionResult UpdateCar(Car obj)
        {
            carService.Update(obj);
            return Ok();
        }
    }
}
