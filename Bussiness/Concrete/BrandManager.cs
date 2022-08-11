using Bussiness.Abctract;
using Bussiness.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_BrandDal.GetAll());
        }

        public IResult AddBrand(Brand brand)
        {
            _BrandDal.Add(brand);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult DeleteBrand(Brand brand)
        {
            _BrandDal.Delete(brand);
            return new SuccessResult(Messages.Successful);
        }

        public IResult UpdateBrand(Brand brand)
        {
            _BrandDal.Update(brand);
            return new SuccessResult(Messages.Successful);
        }   

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_BrandDal.Get(c => c.Id == id));
        }
    }
}
