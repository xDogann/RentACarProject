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
        IColorDal _ColorDal;
        public ColorManager(IColorDal colorDal)
        {
            _ColorDal = colorDal;
        }

        public List<Color> GetAll()
        {
            return _ColorDal.GetAll();
        }

        public void AddColor(Color color)
        {
            _ColorDal.Add(color);
            Console.WriteLine("Renk başarıyla eklendi!");
        }

        public void DeteleColor(Color color)
        {
            _ColorDal.Delete(color);
            Console.WriteLine("Renk başarıyla silindi!");
        }

        public void UpdateColor(Color color)
        {
            _ColorDal.Update(color);
            Console.WriteLine("Renk başarıyla güncellendi!");
        }
    }
}
