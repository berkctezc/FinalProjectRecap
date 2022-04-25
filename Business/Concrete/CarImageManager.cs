using Business.Abstract;
using Business.Constants;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using Business.ValidationResolvers.FluentValidation;

namespace Business.Concrete;

public class CarImageManager : ICarImageService
{
    private readonly ICarImageDal _carImageDAL;

    public CarImageManager(ICarImageDal carImageDAL)
    {
        _carImageDAL = carImageDAL;
    }

    //[SecuredOperation("carImages.add,admin")]
    //[ValidationAspect(typeof(CarImageValidator))]
    public IResult Add(IFormFile file, CarImage carImage)
    {
        var result = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
        if (result != null)
        {
            return result;
        }
        carImage.ImagePath = FileHelper.Add(file);
        carImage.Date = DateTime.Now;
        _carImageDAL.Add(carImage);
        return new SuccessResult();
    }

    //[SecuredOperation("carImages.delete,admin")]
    [ValidationAspect(typeof(CarImageValidator))]
    public IResult Delete(CarImage carImage)
    {
        FileHelper.Delete(carImage.ImagePath);
        _carImageDAL.Delete(carImage);
        return new SuccessResult();
    }

    //[SecuredOperation("carImages.update,admin")]
    [ValidationAspect(typeof(CarImageValidator))]
    public IResult Update(IFormFile file, CarImage carImage)
    {
        var result = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
        if (result != null)
        {
            return result;
        }
        carImage.ImagePath = FileHelper.Update(_carImageDAL.Get(p => p.Id == carImage.Id).ImagePath, file);
        carImage.Date = DateTime.Now;
        _carImageDAL.Update(carImage);
        return new SuccessResult();
    }

    [ValidationAspect(typeof(CarImageValidator))]
    public IDataResult<CarImage> GetById(int id)
    {
        return new SuccessDataResult<CarImage>(_carImageDAL.Get(p => p.Id == id));
    }

    public IDataResult<List<CarImage>> GetAll()
    {
        return new SuccessDataResult<List<CarImage>>(_carImageDAL.GetAll());
    }

    [ValidationAspect(typeof(CarImageValidator))]
    public IDataResult<List<CarImage>> GetImagesByCarId(int id)
    {
        var result = BusinessRules.Run(CheckIfCarImageNull(id));

        if (result != null)
        {
            return new ErrorDataResult<List<CarImage>>(result.Message);
        }

        return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(id).Data);
    }

    //business rules
    private IResult CheckImageLimitExceeded(int carid)
    {
        var carImagecount = _carImageDAL.GetAll(p => p.CarId == carid).Count;
        if (carImagecount >= 5)
        {
            return new ErrorResult(Messages.CheckIfImageLimitExceeded);
        }

        return new SuccessResult();
    }
    private IDataResult<List<CarImage>> CheckIfCarImageNull(int id)
    {
        try
        {
            var path = @"\wwwroot\uploads\logo.jpg";
            var result = _carImageDAL.GetAll(c => c.CarId == id).Any();
            if (!result)
            {
                var carimage = new List<CarImage>();
                carimage.Add(new CarImage { CarId = id, ImagePath = path, Date = DateTime.Now });
                return new SuccessDataResult<List<CarImage>>(carimage);
            }
        }
        catch (Exception exception)
        {

            return new ErrorDataResult<List<CarImage>>(exception.Message);
        }

        return new SuccessDataResult<List<CarImage>>(_carImageDAL.GetAll(p => p.CarId == id).ToList());
    }



}