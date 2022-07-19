using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var addedEntity = context.Entry(entity); // Entry ile bağlan
                addedEntity.State = EntityState.Added; //State durum
                context.SaveChanges(); //SaveChanges ile kaydet
            }
        }

        public void Delete(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var deletedEntity = context.Entry(entity); // Entry ile bağlan
                deletedEntity.State = EntityState.Deleted; //State durum
                context.SaveChanges(); //SaveChanges ile kaydet
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
            
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList() //Null ise hepsini getir. ToList ile hepsini listeliyoruz.
                    : context.Set<Color>().Where(filter).ToList();// Null değilse filtrele getir. 
            }
        }

        public void Update(Color entity)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var updatedEntity = context.Entry(entity); // Entry ile bağlan
                updatedEntity.State = EntityState.Modified; //State durum
                context.SaveChanges(); //SaveChanges ile kaydet
            }
        }
    }
}
