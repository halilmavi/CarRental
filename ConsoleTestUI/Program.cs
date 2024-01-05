using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.Security.Principal;

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (Car car in carManager.GetAll()) { 

    Console.WriteLine(car.Description);
}


Console.WriteLine("-----------");
Car car1 = new Car() { Id = 6,BrandId=4,ColorId=5,DailyPrice=1350,Description="Gri Clio Hatchback",ModelYear=1998};
carManager.Add(car1);


foreach (Car car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}
