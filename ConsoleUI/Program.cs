using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("-> "+ car.Description);
            //}
            foreach (var color in carManager.GetCarsByBrandId(2)) 
            {
                Console.WriteLine("-> {0} " ,color.CarName);
            }
            
            
        }
    }
}