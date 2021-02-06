using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
            {
            CarManager carmanager = new CarManager(new EfCarDal());
            //carmanager.Add(new Car{ BrandId = 1, ColorId = 1, ModelYear = 2010, DailyPrice = 1000, Description = "OPEL" });
            // hatalı kullanım carmanager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = 2011, DailyPrice = -1500, Description = "TO" });
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine("Araç ismi: "  + car.Description + "Aracın günlük fiyatı: " + car.DailyPrice);
            }
            
                

            }
    }
}