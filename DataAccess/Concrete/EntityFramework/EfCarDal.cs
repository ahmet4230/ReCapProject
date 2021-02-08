using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            var result = from c in GetAll()
                         join b in new EfBrandDal().GetAll()
                         on c.BrandId equals b.Id
                         join clr in new EfColorDal().GetAll()
                         on c.ColorId equals clr.Id
                         select new CarDetailDto { CarName = c.Description, BrandName = b.BrandName, ColorName = clr.ColorName, DailyPrice = c.DailyPrice };
            return result.ToList();
        }
        
    }
}
