﻿using Core.DataAccess.EntityFramewok;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,ReCapContext>, ICarDal
    {
        

        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id

                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName,
                                 ModelYear = c.ModelYear,
                                 DailyPrice = c.DailyPrice,
                                 BrandId = b.Id,
                                 
                                 ColorId = co.Id,
                                 Description = c.Description,
                                 ImagePath = (from m in context.CarImages where m.CarId == c.Id select m.ImagePath).FirstOrDefault()

                             };
                return result.ToList();
            }
        }
    }
}
