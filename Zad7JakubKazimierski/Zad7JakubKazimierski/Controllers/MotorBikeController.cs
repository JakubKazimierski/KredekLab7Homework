using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad7JakubKazimierski.Models;
using Zad7JakubKazimierski.Models.Services;

namespace Zad7JakubKazimierski.Controllers
{
    //controller for Motorbike Table in DataBase
    [ApiController]
    [Route("api/motorbikecontroller")]
    public class MotorBikeController : ControllerBase
    {
        private readonly IDataService<MotorBike> _motoService;
        //using dependecy injection
        public MotorBikeController(IDataService<MotorBike> motoService)
        {
            _motoService = motoService;
        }

        /// <summary>
        /// get request
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<MotorBike> motors = _motoService.GetAll();
            return Ok(motors);
        }

        /// <summary>
        /// get by id request
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// post request
        /// </summary>
        /// <param name="motor"></param>
        /// <returns></returns>
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

        /// <summary>
        /// put request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="motor"></param>
        /// <returns></returns>
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

        /// <summary>
        /// delete request
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
