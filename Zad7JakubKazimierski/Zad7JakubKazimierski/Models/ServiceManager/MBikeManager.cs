using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad7JakubKazimierski.Models.Services;

namespace Zad7JakubKazimierski.Models.ServiceManager
{
    public class MBikeManager : IDataService<MotorBike>
    {
        readonly VehicleContext _mBikeContext;

        public MBikeManager(VehicleContext context)
        {
            _mBikeContext = context;
        }

        public IEnumerable<MotorBike> GetAll()
        {
            return _mBikeContext.MBikes.ToList();
        }

        public MotorBike Get(int id)
        {
            return _mBikeContext.MBikes.FirstOrDefault(e => e.MBikeId == id);
        }

        public void Add(MotorBike entity)
        {
            _mBikeContext.MBikes.Add(entity);
            _mBikeContext.SaveChanges();
        }

        public void Update(MotorBike motor, MotorBike entity)
        {
            motor.MBikeModel = entity.MBikeModel;
            motor.MBikeProducer = entity.MBikeProducer;
            motor.DateOfProduction = entity.DateOfProduction;
            motor.MBikePrice = entity.MBikePrice;

            _mBikeContext.SaveChanges();

        }

        public void Delete(MotorBike motor)
        {
            _mBikeContext.MBikes.Remove(motor);
            _mBikeContext.SaveChanges();
        }
    }
}
