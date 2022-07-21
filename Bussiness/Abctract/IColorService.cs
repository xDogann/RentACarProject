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
        List<Color> GetAll();

        void AddColor(Color color);
        void DeteleColor(Color color);
        void UpdateColor(Color color);
    }
}
