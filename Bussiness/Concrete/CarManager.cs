using Bussiness.Abctract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            _CarDal.Add(car);
            Console.WriteLine("Araç başarıyla eklendi!");
            //if (car.DailyPrice < 0 && car.Description.Length < 2)
            //{
            //    Console.WriteLine("HATA! Lütfen kurallara uygun bir şekilde araç ekleme işlemi yapınız. ");
            //}
            //else
            //{
            //    Console.WriteLine("Araç başarıyla eklendi!");
            //    _CarDal.Add(car);
            //    Console.WriteLine("Araç başarıyla eklendi!");
            //}
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
            Console.WriteLine("Araç başarıyla silindi.");
        }

        public void Update(Car car)
        {
            _CarDal.Update(car);
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _CarDal.Get(c => c.CarId == id);
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _CarDal.GetAll(p=>p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _CarDal.GetAll(p=>id == p.ColorId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _CarDal.GetCarDetails();
        
        }
    }
}
