using Business.Abstract;
using Business.Constants;
using Business.ValidationResolvers.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using DataAccess.Abstract;

namespace Business.Concrete;

public class CarManager : ICarService
{
    private readonly ICarDal _carDal;
    private ICarImageService _carImageService;

    public CarManager(ICarDal carDal, ICarImageService carImageService)
    {
        _carDal = carDal;
        _carImageService = carImageService;
    }

    [PerformanceAspect(5)]
    [CacheAspect(duration: 10)]
    public IDataResult<List<Car>> GetAll()
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
    }

    public IDataResult<Car> GetById(int id)
    {
        return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id), Messages.CarListed);
    }

    public IDataResult<List<Car>> GetCarsByBrandId(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll().Where(c => c.BrandId == id).ToList());
    }

    public IDataResult<List<Car>> GetCarsByColorId(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll().Where(c => c.ColorId == id).ToList());
    }

    public IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max), Messages.CarsListed);
    }

    public IDataResult<List<Car>> GetCarsByModelYear(int min, int max)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ModelYear >= min && c.ModelYear <= max), Messages.CarsListed);
    }

    public IDataResult<List<CarDetailDto>> GetCarDetails()
    {
        return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarsListed);
    }

    public IDataResult<List<CarDetailDto>> GetCarDetailsById(Expression<Func<Car, bool>> filter = null)
    {
        return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailsById(filter), "Ürünler Listelendi.");
    }

    [CacheRemoveAspect("ICarService.Get")]
    [ValidationAspect(typeof(CarValidator))]
    public IResult Add(Car car)
    {
        _carDal.Add(car);
        return new SuccessResult(Messages.CarAdded);
    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);
    }

    public IResult Update(Car car)
    {
        _carDal.Update(car);
        return new SuccessResult(Messages.CarUpdated);
    }
        

    [TransactionScopeAspect]
    public IResult AddTransactionalTest(Car car)
    {
        _carDal.Update(car);
        _carDal.Add(car);
        return new SuccessResult(Messages.CarUpdated);
    }
}