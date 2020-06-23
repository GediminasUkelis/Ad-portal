using BLL.Services.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public ActionResult<List<Car>> GetAllCars()
        {
            return Ok(carService.GetAll());
        }

        [HttpGet("/api/Car/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Car> GetCarById([FromRoute] int id)
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
        public ActionResult DeleteCar(int id)
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
