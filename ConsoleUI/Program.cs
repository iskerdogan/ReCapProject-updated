using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdd();
            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.CarDetails();
            //if (result.Success==true)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine("CarName = " + item.CarName + " Marka = " + item.BrandName + " Renk = " + item.ColorName + " DailyPrice = " + item.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            

        }

        private static void CarAdd()
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car {BrandId = 1, ColorId = 1, ModelYear = "1999", DailyPrice =500 , Description = "asdasdasd" });
            ////carManager.Update(new Car { DailyPrice=1000});
            ////carManager.Add(new Car { Id = 6, BrandId = 1, ColorId = 1, ModelYear = "2000", DailyPrice = 1000, Description = "blablabla" });
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id + " " + car.DailyPrice);
            //}
           
        }
    }
}
