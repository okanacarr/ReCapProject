using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {

            _car = new List<Car> {
               new Car {BrandId="Opel",   Id=1, ColorId="blue", DailyPrice=500, ModelYear=2020, Description = "Benzin/Otomatik" },
               new Car {BrandId="Ford",   Id=2, ColorId="black", DailyPrice=350, ModelYear=2007, Description = "Dizel/manuel" },
               new Car {BrandId="Kartal", Id=3, ColorId="purple", DailyPrice=256, ModelYear=1987, Description = "Benzin/manuel" },
               new Car {BrandId="BMW",    Id=4, ColorId="white", DailyPrice=500, ModelYear=2014, Description = "LPG/manuel" },
               new Car {BrandId="Ferrari",Id=5, ColorId="red", DailyPrice=500, ModelYear=2015, Description = "Benzin/Otomatik" },
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);

            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return  _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
