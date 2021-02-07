using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
  public class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllById(4))
            {
                Console.WriteLine(car.Id + "--" + car.Description + "--" + car.BrandId + "--" + car.ColorId);
            }

        }
    }
}
