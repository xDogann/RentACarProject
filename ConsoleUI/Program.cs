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

            //GetAllCars(carManager);

            GetCarsDetail(carManager);

        }

        private static void GetCarsDetail(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("- Araç ID: {0}, Araç Adı: {1}, Araç Markası: {2}, Araç Rengi: {3}, Araç Yılı: {4}", car.CarId, car.CarName, car.BrandName, car.ColorName, car.ModelYear);
            }
        }

        private static void GetAllCars(CarManager carManager)
        {
            var cars = carManager.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.CarName} - {car.ModelYear} Model");
            }
        }



    }
}