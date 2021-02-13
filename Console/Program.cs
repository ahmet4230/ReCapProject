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

            //CarDetails();

            //UserManager userManager = new UserManager(new EfUserDal());
            //userManager.Add(new User {  FirstName = "ahmet", LastName = "batman", Email = "aa@hotmail.com", Password = "123" });
            //GetRentDetails(rentalManager);

            //UserManager userManager = new UserManager(new EfUserDal());
            /*userManager.Add(new User { FirstName = "ali", LastName = "batman", Email = "a@hotmail.com", Password = "1234" })*/;
            //userManager.Update(new User {UserId = 2 , FirstName = "kerim" });
            //userManager.Delete(new User { UserId = 3 });
            //foreach (var user in userManager.GetAll().Data)
            //{
            //    Console.WriteLine("Kullanııcı ismi: {0} kullanıcı soyad: {1} kullanıcı Email: {2} " ,  user.FirstName , user.LastName , user.Email );
            //}

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer {   UserId = 1, CompanyName = "new year2021" });
            //customerManager.Update(new Customer { CustomerId =8 , UserId = 1 , CompanyName = "new yearr 2022" });
            //customerManager.Delete(new Customer { UserId = 2, CustomerId = 3 });
            //foreach (var customer in customerManager.GetAll().Data)
            //{
            //    Console.WriteLine("Kullanııcı no: {0} müşteri no: {1} kampanya adı: {2} ", customer.UserId, customer.CustomerId, customer.CompanyName);
            //}

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //rentalManager.Add(new Rental { CarId = 6002, CustomerId = 8 ,  RentDate = new DateTime(2001)  });
            //rentalManager.Add(new Rental { CarId = 5003, CustomerId = 1, RentDate = new DateTime(2018, 5, 2) , ReturnDate = new DateTime(2018 ,6,3) });
            var result = rentalManager.GetRentalDetails();
            foreach (var rental in result.Data)
            {
                Console.WriteLine("Aracı kiralayan kiş: {0} Kiralama Numarası: {1} Kiralama tarihi: {2}  Teslim tarihi: {3}  " , rental.UserName , rental.RentalId , rental.RentDate ,rental.ReturnDate );
            }


            

            

        }

        

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var cardetails in carManager.GetCarDetails().Data)
            {

                Console.WriteLine("Araç ismi : {0}  Araç Modeli: {1} Araç rengi: {2} Araç günlük ücreti: {3} ", cardetails.CarName, cardetails.BrandName,
                     cardetails.ColorName, cardetails.DailyPrice);

            }
            Console.ReadLine();
        }
    }
}