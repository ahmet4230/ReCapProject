using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
            new Car { BrandId = 1, ColorId = 1, ModelYear = 2010, DailyPrice = 1000, Description = "OPEL" },
            new Car { BrandId = 2, ColorId = 2, ModelYear = 2011, DailyPrice = 1500, Description = "TOYOTA" },
            new Car { BrandId = 3, ColorId = 3, ModelYear = 2012, DailyPrice = 2000, Description = "FİAT" },
            new Car { BrandId = 4, ColorId = 4, ModelYear = 2013, DailyPrice = 2500, Description = "FORD" },
            new Car { BrandId = 5, ColorId = 4, ModelYear = 2014, DailyPrice = 3000, Description = "BMW" },
            };
            

        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = carToDelete = _car.SingleOrDefault(p => p.BrandId == car.BrandId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int ColorId)
        {
            return _car.Where(c => c.ColorId == ColorId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = carUpdate = _car.SingleOrDefault(p => p.CarId == car.CarId);
            carUpdate.CarId = car.CarId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
        }
    }
}
