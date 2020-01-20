using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zad7JakubKazimierski.Models.Services;

namespace Zad7JakubKazimierski.Models.ServiceManager
{

    //class overriding interface with methods get, add, update, delete
    //used as service and changing data in Database
    public class CarManager : IDataService<Car>
    {
        readonly VehicleContext _carContext;

        public CarManager(VehicleContext context)
        {
            _carContext = context;
        }

        public IEnumerable<Car> GetAll()
        {
            return _carContext.Cars.ToList();
        }

        public Car Get(int id)
        {
            return _carContext.Cars.FirstOrDefault(e => e.CarId == id);
        }

        public void Add(Car entity)
        {
            _carContext.Cars.Add(entity);
            _carContext.SaveChanges();
        }

        public void Update(Car car, Car entity)
        {
            car.CarModel = entity.CarModel;
            car.CarProducer = entity.CarProducer;
            car.DateOfProduction = entity.DateOfProduction;
            car.CarPrice = entity.CarPrice;

            _carContext.SaveChanges();

        }

        public void Delete(Car car)
        {
            _carContext.Cars.Remove(car);
            _carContext.SaveChanges();
        }
    }
}
