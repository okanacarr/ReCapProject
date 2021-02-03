using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Cars;
        public InMemoryCarDal()
        {

            _Cars = new List<Car> {
               new Car {BrandId="Opel",   Id=1000, ColorId="blue", DailyPrice=500, ModelYear=2020, Description = "Benzin/Otomatik" },
               new Car {BrandId="Ford",   Id=2000, ColorId="black", DailyPrice=350, ModelYear=2007, Description = "Dizel/manuel" },
               new Car {BrandId="Kartal", Id=3000, ColorId="purple", DailyPrice=256, ModelYear=1987, Description = "Benzin/manuel" },
               new Car {BrandId="BMW",    Id=4000, ColorId="white", DailyPrice=500, ModelYear=2014, Description = "LPG/manuel" },
               new Car {BrandId="Ferrari",Id=5000, ColorId="red", DailyPrice=500, ModelYear=2015, Description = "Benzin/Otomatik" },
            };
        }
        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _Cars.SingleOrDefault(c => c.Id == car.Id);
            _Cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _Cars;
        }

        public List<Car> GetAllById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _Cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _Cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
