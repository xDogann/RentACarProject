using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abctract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetAllByColorId(int id);
        IDataResult<Color> GetById(int id);

        IResult AddColor(Color color);
        IResult DeleteColor(Color color);
        IResult UpdateColor(Color color);
    }
}
