using Bussiness.Abctract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Bussiness.Constants;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _ColorDal;
        public ColorManager(IColorDal colorDal)
        {
            _ColorDal = colorDal;
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_ColorDal.GetAll());
        }

        public IResult AddColor(Color color)
        {
            _ColorDal.Add(color);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult DeleteColor(Color color)
        {
            _ColorDal.Delete(color);
            return new SuccessResult(Messages.Successful);
        }

        public IResult UpdateColor(Color color)
        {
            _ColorDal.Update(color);
            return new SuccessResult(Messages.Successful);
        }

        public IDataResult<List<Color>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Color>>(_ColorDal.GetAll(p => id == p.ColorId));
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_ColorDal.Get(c => c.ColorId == id));
        }
    }
}
