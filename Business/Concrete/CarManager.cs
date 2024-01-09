using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
            this._carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.CarName.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            if(car.CarName.Length < 2)
            {
                Console.WriteLine("Araba ismi minumum 2 karakter içermeledir.");
            }
            if (car.DailyPrice >= 0)
            {
                Console.WriteLine("Araba günlük ücreti 0 dan büyük olmalıdır.");
            }
            else
            {
                Console.WriteLine("Araba günlük ücreti 0 dan büyük olmalı ve araba ismi minumum 2 karakter içermelidir.");
            }

        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(p => p.Id == id);
        }

        public List<Car> GetByBrandId(int id)
        {
            return _carDal.GetAll(b => b.BrandId == id);
        }

        public List<Car> GetByColorId(int id)
        {
            return _carDal.GetAll(b => b.ColorId == id);
        }
    }
}
