using Bussiness.Abctract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _BrandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _BrandDal = brandDal;
        }

        public void AddBrand(Brand brand)
        {
            Console.WriteLine("Marka başarıyla eklendi!");
            _BrandDal.Add(brand);
        }

        public void DeleteBrand(Brand brand)
        {
            _BrandDal.Delete(brand);
            Console.WriteLine("Marka başarıyla silindi!");
        }

        public List<Brand> GetAll()
        {
            return _BrandDal.GetAll();
        }

        public void UpdateBrand(Brand brand)
        {
            _BrandDal.Update(brand);
        }
    }
}
