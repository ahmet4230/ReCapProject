using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {

            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç eklendi");
            }
            else
            {
                Console.WriteLine("Lütfen tekrar deneyin aracın günlük fiyatı sıfır olmalı ve araç ismi 2 karakterden uzun olmalı");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
