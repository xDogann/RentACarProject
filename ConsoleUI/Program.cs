using Bussiness.Concrete;
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
            CarManager carManager = new CarManager(new EfCarDal());

            //AddNewCar(carManager);

            
            


        }

        private static void AddNewCar(CarManager carManager)
        {
            Car newCar = new Car
            {
                CarName = "x90C",
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 2000,
                ModelYear = 2022,
                Description = "Volvo x90C Mavi araba"
            };
            carManager.Add(newCar);
        }

        



    }
}