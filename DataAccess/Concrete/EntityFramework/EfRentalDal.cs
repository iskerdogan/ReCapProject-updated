using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal:EfEntityRepositoryBase<Rental,RcdbContext>,IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using(RcdbContext context = new RcdbContext())
            {
                var result = from rt in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on rt.CarId equals c.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cus in context.Customers
                             on rt.CustomerId equals cus.Id
                             join us in context.Users
                             on cus.UserId equals us.Id
                             select new CarRentalDetailDto
                             {
                                 RentalId = rt.Id,
                                 CutomerName = us.FirstName,
                                 CustomerLastName = us.LastName,
                                 CustomerCompanyName = cus.CompanyName,
                                 CarName = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = col.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 RentDate = rt.RentDate,
                                 ReturnDate = rt.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
