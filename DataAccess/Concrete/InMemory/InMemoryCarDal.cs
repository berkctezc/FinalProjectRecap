using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;
        public InMemoryCarDal()
        {
            _carList = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150000,ModelYear="2002",Description="Külüstür"},
                new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=800000,ModelYear="1968",Description="Retro"},
                new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=250000,ModelYear="1996",Description="Aile"},
                new Car{Id=3,BrandId=2,ColorId=1,DailyPrice=300000,ModelYear="2012",Description="Spor"},
                new Car{Id=4,BrandId=3,ColorId=2,DailyPrice=80000,ModelYear="2008",Description="Günlük"},
                new Car{Id=5,BrandId=3,ColorId=3,DailyPrice=130000,ModelYear="2018",Description="Fiyat-Performans"},
                new Car{Id=6,BrandId=4,ColorId=1,DailyPrice=260000,ModelYear="2015",Description="Dağ"},
                new Car{Id=7,BrandId=5,ColorId=3,DailyPrice=110000,ModelYear="2005",Description="Külüstür v2"}
            };
        }

        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDel = null;
            carToDel = _carList.SingleOrDefault(c => c.Id == c.Id);

            _carList.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _carList;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _carList.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetAllByColor(int colorId)
        {
            return _carList.Where(c => c.ColorId == colorId).ToList();
        }

        public Car GetById(int id)
        {
            return _carList.Single(c => c.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _carList.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
