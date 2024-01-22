using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System.Security.Principal;


static void GetCarAll() 
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (Car car in carManager.GetAll().Data)
    {

        Console.WriteLine(car.CarId +" - "+car.BrandId+" - "+car.ModelYear+" - "+car.DailyPrice+" - " + car.Description);
    }
    Console.WriteLine(carManager.GetAll().Message+" -- "+carManager.GetAll().Success);
}


static void GetByColorId()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (Car car in carManager.GetByColorId(1).Data)
    {

        Console.WriteLine(car.Description);
    }
}



static void GetAllColor()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());

    foreach (Color color in colorManager.GetAll().Data)
    {
        Console.WriteLine(color.ColorId + " " + color.ColorName);
    }
}


GetCarAll();
//GetByColorId();
//GetAllColor();

/*
CarManager carManager = new CarManager(new EfCarDal());


foreach(CarDetailDto carDetail in carManager.GetCarDetails().Data )
{
    Console.WriteLine(carDetail.CarId+" - "+carDetail.ColorName+" - " + carDetail.BrandName+" - "+carDetail.DailyPrice);
}
*/