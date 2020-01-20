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
    [Route("api/motorbikecontroller")]
    public class MotorBikeController : ControllerBase
    {
        private readonly IDataService<MotorBike> _motoService;

        public MotorBikeController(IDataService<MotorBike> motoService)
        {
            _motoService = motoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<MotorBike> motors = _motoService.GetAll();
            return Ok(motors);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            MotorBike motor = _motoService.Get(id);

            if (motor == null)
            {
                return NotFound("MotorBike is not in DataBase.");
            }

            return Ok(motor);

        }

        [HttpPost]
        public IActionResult Post([FromBody] MotorBike motor)
        {
            if (motor == null)
            {
                return BadRequest("Null value");
            }

            _motoService.Add(motor);
            return CreatedAtRoute("Get", new { Id = motor.MBikeId }, motor);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MotorBike motor)
        {
            if (motor == null)
            {
                return BadRequest("Motor is Null");
            }

            MotorBike motoToUpdate = _motoService.Get(id);

            if (motoToUpdate == null)
            {
                return NotFound("The motor record couldn't be found");

            }

            _motoService.Update(motoToUpdate, motor);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            MotorBike moto = _motoService.Get(id);
            if (moto == null)
            {
                return NotFound("The Motor record couldn't be found");
            }

            _motoService.Delete(moto);
            return NoContent();
        }

    }
}
