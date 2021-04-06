using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<CarBasicDetailDto>> CarBasicDetailDto();
        IDataResult<List<CarBasicDetailDto>> CarBasicDetailByBrandId(int brandId);
        IDataResult<List<CarBasicDetailDto>> CarBasicDetailByColorId(int colorId);
        IDataResult<List<CarDetailDto>> CarDetails();
        IDataResult<List<CarDetailDto>> CarDetailsById(int carId);

    }
}
