using Bussiness.Abctract;
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
        public List<Color> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
