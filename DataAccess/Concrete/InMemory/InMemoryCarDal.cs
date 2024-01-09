using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>() {
            
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=750,Description="Beyaz Hyundai Accent Blue",ModelYear=2015 },
                new Car{Id=2,BrandId=1,ColorId=1,DailyPrice=750,Description="Beyaz Hyundai i30",ModelYear=2012 },
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=1250,Description="Beyaz Mercedes",ModelYear=2017 },
                new Car{Id=4,BrandId=3,ColorId=1,DailyPrice=850,Description="Siyah Volvo s40",ModelYear=2015 },
                new Car{Id=5,BrandId=3,ColorId=2,DailyPrice=2050,Description="Kırmızı Volvo s80",ModelYear=2019 }

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(p => p.Id == id);

        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;    
            carToUpdate.Description= car.Description;   
        }
    }
}
