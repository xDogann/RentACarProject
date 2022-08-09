using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abctract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<Brand> GetById(int id);

        IResult AddBrand(Brand brand);
        IResult UpdateBrand(Brand brand);
        IResult DeleteBrand(Brand brand);
    }
}
