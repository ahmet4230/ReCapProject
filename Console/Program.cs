using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarService carManager = new CarService(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Brand Id: " + car.BrandId + " Color Id: " + car.ColorId + "Model Year: " + car.ModelYear + " Daily Price: " + car.DailyPrice + "Description: " + car.Description  );
            }

        }
    }
}