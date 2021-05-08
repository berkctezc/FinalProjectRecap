using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarProjectDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarProjectDBContext context = new CarProjectDBContext())
            {
                var result =
                    from car in context.Cars
                    join brand in context.Brands on car.BrandId equals brand.Id
                    join color in context.Colors on car.Id equals color.Id
                    join image in context.CarImages on car.Id equals image.CarId 
                    select new CarDetailDto
                    {
                        Id = car.Id,
                        BrandName = brand.Name,
                        ColorName = color.Name,
                        ModelYear = car.ModelYear,
                        ImagePath = image.ImagePath,
                        DailyPrice = car.DailyPrice,
                        Description = car.Description,
                        Date = image.Date
                    };
                return result.ToList();
            }
        }

        public List<CarDetailDto> GetCarDetailsById(Expression<Func<Car, bool>> filter = null)
        {
            using (CarProjectDBContext context = new CarProjectDBContext())
            {
                var result =
                    from car in filter == null ? context.Cars : context.Cars.Where(filter)
                    join brand in context.Brands on car.BrandId equals brand.Id
                    join color in context.Colors on car.ColorId equals color.Id
                    join image in context.CarImages on car.Id equals image.CarId
                    select new CarDetailDto
                    {
                        Id = car.Id,
                        BrandName = brand.Name,
                        ColorName = color.Name,
                        DailyPrice = car.DailyPrice,
                        Description = car.Description,
                        ModelYear = car.ModelYear,
                        ImageId = image.Id,
                        ImagePath = image.ImagePath,
                        Date = image.Date
                    };
                return result.ToList();
            }
        }
    }
}