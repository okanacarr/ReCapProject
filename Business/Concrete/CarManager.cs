using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 && car.Id > 2)
            {
                _carDal.Add(car);
                System.Console.WriteLine("Araba eklendi");
            }
            else
            {
                System.Console.WriteLine("Lütfen günlük fiyatı 0'dan büyük ve araba ismini 2 karakterden uzun giriniz! Girdiğiniz değerler : Günlük fiyatı : {0} Araba adı : {1}",
                    car.DailyPrice, car.Id);
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(string id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetAllByColorId(string id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<Car> GetAllById(int id)
        {
            return _carDal.GetAll(p => p.Id == id);
        }

        public List<Car> GetAllByModelYear(int id)
        {
            return _carDal.GetAll(p => p.ModelYear == id);

        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }
    }
}