using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void AddBrand(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                Console.WriteLine("Tebrikler, Model ismi sisteme başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Model ismi en az 2 karakter olmalıdır!");
            }
        }

      

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

    
    }
}
