﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework;

public class EfRentalDal : EfEntityRepositoryBase<Rental, CarProjectDBContext>, IRentalDal
{
    public List<RentalDetailDto> GetRentalDetails()
    {
        using (var context = new CarProjectDBContext())
        {
            var result =
                from rental in context.Rentals
                join car in context.Cars on rental.CarId equals car.Id
                join customer in context.Customers on rental.CustomerId equals customer.Id
                join brand in context.Brands on car.BrandId equals brand.Id
                join user in context.Users on customer.UserId equals user.Id
                select new RentalDetailDto
                {
                    Id = rental.Id,
                    BrandName = brand.Name,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    RentDate = rental.RentDate,
                    ReturnDate = rental.ReturnDate,
                };
            return result.ToList();
        }
    }
}