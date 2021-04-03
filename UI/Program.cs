using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //InMemoryTest();

            Console.WriteLine("EF");
            CarManager carManagerEF = new CarManager(new EFCarDal());

           //EFAddEntries(carManagerEF);

            foreach (var car in carManagerEF.GetAll())
            {
                DetailPrint(car);
            }



        }

        private static void EFAddEntries(CarManager carManagerEF)
        {
            carManagerEF.Add(new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150000, ModelYear = "2002", Description = "Külüstür" });
            carManagerEF.Add(new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 800000, ModelYear = "1968", Description = "Retro" });
            carManagerEF.Add(new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 250000, ModelYear = "1996", Description = "Aile" });
            carManagerEF.Add(new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 300000, ModelYear = "2012", Description = "Spor" });
            carManagerEF.Add(new Car { Id = 4, BrandId = 3, ColorId = 2, DailyPrice = 80000, ModelYear = "2008", Description = "Günlük" });
            carManagerEF.Add(new Car { Id = 5, BrandId = 3, ColorId = 3, DailyPrice = 130000, ModelYear = "2018", Description = "Fiyat-Performans" });
            carManagerEF.Add(new Car { Id = 6, BrandId = 4, ColorId = 1, DailyPrice = 260000, ModelYear = "2015", Description = "Dağ" });
            carManagerEF.Add(new Car { Id = 7, BrandId = 5, ColorId = 3, DailyPrice = 110000, ModelYear = "2005", Description = "Külüstür v2" });
        }

        private static void InMemoryTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();

            GetAllTest(carManager);
            Console.WriteLine("------");
            AddTest(inMemoryCarDal);
            Console.WriteLine("------");
            GetByIdTest(inMemoryCarDal);
            Console.WriteLine("------");
            inMemoryCarDal.Update(new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 800000, ModelYear = "1964", Description = "Retro Update" });

            Console.WriteLine("in memory");
            foreach (var car in carManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(car.Description);
            }
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
