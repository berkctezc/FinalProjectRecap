using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();

            GetAllTest(carManager);
            Console.WriteLine("------");
            AddTest(inMemoryCarDal);
            Console.WriteLine("------");
            GetByIdTest(inMemoryCarDal);
            Console.WriteLine("------");
            inMemoryCarDal.Update(new Car{ Id = 2,BrandId = 2,ColorId = 2,DailyPrice = 800000,ModelYear = "1964",Description = "Retro Update"});
            //inMemoryCarDal.Update(inMemoryCarDal.GetById(2),new Car{ Id = 2,BrandId = 2,ColorId = 2,DailyPrice = 800000,ModelYear = "1964",Description = "Retro Update"});
            //inMemoryCarDal.Delete(inMemoryCarDal.GetById(2));
            //sonradan düzeltilecek: delete, update

        }

        private static void GetByIdTest(InMemoryCarDal inMemoryCarDal)
        {
            Console.WriteLine(inMemoryCarDal.GetById(5).Description);
        }

        private static void AddTest(InMemoryCarDal inMemoryCarDal)
        {
            inMemoryCarDal.Add(new Car { Id = 8, BrandId = 8, ColorId = 8, DailyPrice = 800000, ModelYear = "1972", Description = "Yeni Retro" });

            foreach (var car in inMemoryCarDal.GetAll())
            {
                DetailPrint(car);
            }
        }

        private static void DetailPrint(Car car)
        {
            Console.WriteLine(
                "* Aciklama: {0} | Ücret: {1} | Yıl: {2} | Marka: {3} | Renk: {4} ", car.Description,
                car.DailyPrice,
                car.ModelYear,
                car.BrandId,
                car.ColorId);
        }

        private static void GetAllTest(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                DetailPrint(car);
            }
        }
    }
}
