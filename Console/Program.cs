using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using Entities.DTOs;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
            {
            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car{ BrandId = 1, ColorId = 1, ModelYear = 2010, DailyPrice = 1000, Description = "OPEL" });
            // //hatalı kullanım carmanager.Add(new Car { BrandId = 2, ColorId = 2, ModelYear = 2011, DailyPrice = -1500, Description = "TO" });
            //foreach (var car in carManager.GetAll())
            //{
            //Console.WriteLine("Araç Eklendi ! " +  "Araç ismi: "  + car.Description + "Aracın günlük fiyatı: " + car.DailyPrice);
            //}
            //carManager.Delete(new Car { Id = 5002 });
            //carManager.Update(new Car {Id = 3009, BrandId = 1, ColorId = 1, ModelYear = 2010, DailyPrice = 1000, Description = "OPEeeeL"});
            //Console.WriteLine(carManager.GetById(3009).Id);



            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color {Id = 2 , ColorName = "White" });
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine("Color Id:  " + color.Id + " "  + "Color Name: " + color.ColorName);
            //}
            //colorManager.Delete(new Color { Id = 10});
            //colorManager.Update(new Color { Id = 1 , ColorName = "Green"});
            //Console.WriteLine(colorManager.GetById(1).ColorName);



            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { Id = 1, BrandName = "Corsa" });
            //brandManager.Add(new Brand { Id = 3, BrandName = "vectra" });
            //foreach (var brand  in brandManager.GetAll())
            //{
            //    Console.WriteLine("Brand Id:  " +   brand.Id + " " + " BrandName: "+ " " +   brand.BrandName);
            //}
            //brandManager.Update(new Brand { Id = 1, BrandName = "Combo" });
            //brandManager.Delete(new Brand { Id = 1 });
            //Console.WriteLine(brandManager.GetById(2).BrandName);

            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var cardetails in carManager.GetCarDetails())
            {
                
                Console.WriteLine("Araç ismi : {0}  Araç Modeli: {1} Araç rengi: {2} Araç günlük ücreti: {3} " ,cardetails.CarName ,  cardetails.BrandName ,
                     cardetails.ColorName,   cardetails.DailyPrice   );
            }
           
           










        }
    }
}