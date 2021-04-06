using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Color> {
        //    new Color{ Id=1,BrandId=1,ColorId=1,ModelYear="2021",DailyPrice=600000,Description="Hasar Kayıtsız." },
        //    new Color{ Id=2,BrandId=1,ColorId=2,ModelYear="2020",DailyPrice=600000,Description="Doktordan Satılık" },
        //    new Color{ Id=3,BrandId=2,ColorId=1,ModelYear="2015",DailyPrice=600000,Description="Hastasına" },
        //    new Color{ Id=4,BrandId=1,ColorId=2,ModelYear="1999",DailyPrice=600000,Description="Serseriden serseriye aile arabası değildir." },
        //    new Color{ Id=5,BrandId=2,ColorId=1,ModelYear="2018",DailyPrice=600000,Description="Çıtır Hasarlı" },
        //    };
        //}

        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Color carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        //    _cars.Remove(carToDelete);
        //}

        //public Color Get(Expression<Func<Color, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Color> GetAll()
        //{
        //    return _cars;
        //}

        //public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Color> GetByld(int Id)
        //{
        //    return _cars.Where(c => c.Id == Id).ToList();
        //}

        //public void Update(Color car)
        //{
        //    Color carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        //    carToDelete.BrandId = car.BrandId;
        //    carToDelete.ColorId = car.ColorId;
        //    carToDelete.ModelYear = car.ModelYear;
        //    carToDelete.DailyPrice = car.DailyPrice;
        //    carToDelete.Description = car.Description;
        //}
        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public List<CarBasicDetailDto> CarBasicDetailDto()
        {
            throw new NotImplementedException();
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
