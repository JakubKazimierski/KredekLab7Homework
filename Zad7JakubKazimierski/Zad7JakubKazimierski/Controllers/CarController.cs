using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad7JakubKazimierski.Models;
using Zad7JakubKazimierski.Models.Services;

namespace Zad7JakubKazimierski.Controllers
{
    [ApiController]
    [Route("[api/car]")]
    public class CarController : ControllerBase
    {
        private readonly IDataService<Car> _carService;

        private CarController(IDataService<Car> carService)
        { 
            _carService = carService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Car> cars = _carService.GetAll();
            return Ok(cars);
        }

        [HttpGet("{id}",Name = "Get")]
        public IActionResult Get(int id)
        {
            Car car = _carService.Get(id);

            if (car == null)
            {
                return NotFound("Car is not in DataBase.");
            }

            return Ok(car);

        }

        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest("Null value");
            }

            _carService.Add(car);
            return CreatedAtRoute("Get", new { Id = car.CarId }, car);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Car car)
        { 
            if (car == null)
            {
                return BadRequest("Car is Null");
            }

            Car carToUpdate = _carService.Get(id);

            if(carToUpdate == null)
            {
                return NotFound("The car record couldn't be found");

            }

            _carService.Update(carToUpdate, car);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Car car = _carService.Get(id);
            if(car == null)
            {
                return NotFound("The car record couldn't be found");
            }

            _carService.Delete(car);
            return NoContent();
        }

    }
}
