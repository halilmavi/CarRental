using Entities.Concrete;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> GetByBrandId(int id);
        List<Car> GetByColorId(int id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
