using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Security.Principal;


static void GetCarAll()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (Car car in carManager.GetAll())
    {

        Console.WriteLine(car.Description);
    }
}


static void GetByColorId()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (Car car in carManager.GetByColorId(1))
    {

        Console.WriteLine(car.Description);
    }
}

//GetCarAll();
//GetByColorId();


CarManager car = new CarManager(new EfCarDal());
Car car1 = new Car() {BrandId=3,CarName="F",ColorId=1,DailyPrice=0,Description= "Beyaz Ford Focus",ModelYear=2020};

car.Add(car1);
