using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofec.Caching;
using Core.Aspects.Autofec.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<CarBasicDetailDto>> CarBasicDetailByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarBasicDetailDto>>(_carDal.CarBasicDetailDto().FindAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<CarBasicDetailDto>> CarBasicDetailByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarBasicDetailDto>>(_carDal.CarBasicDetailDto().FindAll(c => c.ColorId == colorId));
        }

        public IDataResult<List<CarBasicDetailDto>> CarBasicDetailDto()
        {
            return new SuccessDataResult<List<CarBasicDetailDto>>(_carDal.CarBasicDetailDto());
        }

        public IDataResult<List<CarDetailDto>> CarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }


        public IDataResult<List<CarDetailDto>> CarDetailsById(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails().FindAll(c => c.CarId == carId));
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }


        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == carId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
