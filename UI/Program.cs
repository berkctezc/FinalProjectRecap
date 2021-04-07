using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
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
            CarManager carManagerEF = new CarManager(new EfCarDal());
            BrandManager brandManagerEF = new BrandManager(new EfBrandDal());
            ColorManager colorManagerEF = new ColorManager(new EfColorDal());
            UserManager userManagerEF = new UserManager(new EfUserDal());
            CustomerManager customerManagerEF = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManagerEF = new RentalManager(new EfRentalDal());


            //Test Edildi:GetAll,GetById,Add,Update,Delete,DTO

            //AddEntries(carManagerEF, brandManagerEF, colorManagerEF,customerManagerEF,userManagerEF);


            //UpdateEntries(carManagerEF, brandManagerEF, colorManagerEF);
            DeleteTest(colorManagerEF);

            Console.WriteLine("===Car GetAll===");
            //GetAllCarDetail(carManagerEF);
            Console.WriteLine("---DTO GetCarDetails:");
            GetCarDetailsDtoTest(carManagerEF);

            Console.WriteLine("---Car GetById:" + carManagerEF.GetById(2).Data.Description);

            //BrandGetAll(brandManagerEF);
            //ColorGetAll(colorManagerEF);
            //UserGetAll(userManagerEF);
            //CustomerGetAll(customerManagerEF);

            //RentalAddTest(rentalManagerEF);
            RentalGetAll(rentalManagerEF);

        }//Metodlar

        private static void RentalGetAll(RentalManager rentalManagerEF)
        {
            var result = rentalManagerEF.GetAll();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.RentDate);
                }
            }
        }

        private static void RentalAddTest(RentalManager rentalManagerEF)
        {
            rentalManagerEF.Add(new Rental
            {
                Id = 1,
                CarId = 2,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate = DateTime.Today
            });
        }

        private static void CustomerGetAll(CustomerManager customerManagerEF)
        {
            var result = customerManagerEF.GetAll();
            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
        }

        private static void UserGetAll(UserManager userManagerEF)
        {
            var result = userManagerEF.GetAll();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName);
                }
            }
        }

        private static void ColorGetAll(ColorManager colorManagerEF)
        {
            Console.WriteLine("===Color===");
            foreach (var color in colorManagerEF.GetAll().Data)
                Console.WriteLine("* Color Id:{0} | Color Name: {1}", color.Id, color.Name);
            Console.WriteLine("---Color GetById:" + colorManagerEF.GetById(3).Data.Name);
        }

        private static void BrandGetAll(BrandManager brandManagerEF)
        {
            Console.WriteLine("===Brand GetAll===");
            foreach (var brand in brandManagerEF.GetAll().Data)
                Console.WriteLine("* Brand Id:{0} | Brand Name: {1}", brand.Id, brand.Name);
            Console.WriteLine("---Brand GetById:" + brandManagerEF.GetById(4).Data.Name);
        }

        private static void GetCarDetailsDtoTest(CarManager carManagerEF)
        {
            foreach (var car in carManagerEF.GetCarDetails().Data)
            {
                Console.WriteLine(
                    "* Aciklama: {0} | Ücret: {1} | Yıl: {2} | Marka: {3} | Renk: {4} ",
                    car.Description,
                    car.DailyPrice,
                    car.ModelYear,
                    car.BrandName,
                    car.ColorName);
            }
        }

        private static void GetAllCarDetail(CarManager carManagerEF)
        {
            foreach (var car in carManagerEF.GetAll().Data)
            {
                Console.WriteLine(
                "* Aciklama: {0} | Ücret: {1} | Yıl: {2} | Marka: {3} | Renk: {4} ",
                car.Description,
                car.DailyPrice,
                car.ModelYear,
                car.BrandId,
                car.ColorId);
            }
        }
        private static void DeleteTest(ColorManager colorManagerEF)
        {
            colorManagerEF.Add(new Color { Id = 5, Name = "YanlışRenk" });
            colorManagerEF.Delete(new Color { Id = 5, Name = "YanlışRenk" });
        }

        private static void AddEntries(CarManager carManagerEF, BrandManager brandManagerEF, ColorManager colorManagerEF, CustomerManager customerManagerEF,UserManager userManagerEF)
        {
            carManagerEF.Add(new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 150000, ModelYear = "2002", Description = "Külüstür" });
            carManagerEF.Add(new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 800000, ModelYear = "1968", Description = "Retro" });
            carManagerEF.Add(new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 250000, ModelYear = "1996", Description = "Aile" });
            carManagerEF.Add(new Car { Id = 4, BrandId = 2, ColorId = 1, DailyPrice = 300000, ModelYear = "2012", Description = "Spor" });
            carManagerEF.Add(new Car { Id = 5, BrandId = 3, ColorId = 2, DailyPrice = 80000, ModelYear = "2008", Description = "Günlük" });
            carManagerEF.Add(new Car { Id = 6, BrandId = 3, ColorId = 3, DailyPrice = 130000, ModelYear = "2018", Description = "Fiyat-Performans" });
            carManagerEF.Add(new Car { Id = 7, BrandId = 4, ColorId = 1, DailyPrice = 260000, ModelYear = "2015", Description = "Dağ" });
            carManagerEF.Add(new Car { Id = 8, BrandId = 5, ColorId = 3, DailyPrice = 110000, ModelYear = "2005", Description = "Külüstür v2" });
            carManagerEF.Add(new Car { Id = 9, BrandId = 2, ColorId = 4, DailyPrice = 275000, ModelYear = "2014", Description = "Hız" });

            Console.WriteLine("Added Car Entries with EF...");


            brandManagerEF.Add(new Brand { Id = 1, Name = "Tofaş" });
            brandManagerEF.Add(new Brand { Id = 2, Name = "Ford" });
            brandManagerEF.Add(new Brand { Id = 3, Name = "Volvo" });
            brandManagerEF.Add(new Brand { Id = 4, Name = "Nissan" });
            brandManagerEF.Add(new Brand { Id = 5, Name = "Volkswagen" });
            brandManagerEF.Add(new Brand { Id = 6, Name = "Ferrari" });


            Console.WriteLine("Added Brand Entries with EF...");

            colorManagerEF.Add(new Color { Id = 1, Name = "Kırmızı" });
            colorManagerEF.Add(new Color { Id = 2, Name = "Beyaz" });
            colorManagerEF.Add(new Color { Id = 3, Name = "Siyah" });
            colorManagerEF.Add(new Color { Id = 4, Name = "Mavi" });

            Console.WriteLine("Added Color Entries with EF...");

            customerManagerEF.Add(new Customer { Id = 1, CompanyName = "A Firması", UserId = 1 });
            customerManagerEF.Add(new Customer { Id = 2, CompanyName = "B Firması", UserId = 2 });
            customerManagerEF.Add(new Customer { Id = 3, CompanyName = "C Firması", UserId = 3 });
            customerManagerEF.Add(new Customer { Id = 4, CompanyName = "D Firması", UserId = 4 });

            Console.WriteLine("Added Customer Entries with EF...");

            userManagerEF.Add(new User { Id = 1, FirstName = "Berkcan", LastName = "Tezcaner", Email = "berkcantezcaner@gmail.com", Password = "123456" });
            userManagerEF.Add(new User { Id = 2, FirstName = "Ayşe", LastName = "Demir", Email = "a.demir@mail.com", Password = "123456" });
            userManagerEF.Add(new User { Id = 3, FirstName = "Ahmet", LastName = "Yılmaz", Email = "a.yilmaz@mail.com", Password = "123456" });
            userManagerEF.Add(new User { Id = 4, FirstName = "John", LastName = "Carpenter", Email = "j.carpenter@mail.com", Password = "123456" });
            userManagerEF.Add(new User { Id = 5, FirstName = "Alfred", LastName = "Hitchcock", Email = "a.hitchcock@mail.com", Password = "123456" });


            Console.WriteLine("Added User Entries with EF...");
        }

        private static void UpdateEntries(CarManager carManagerEF, BrandManager brandManagerEF, ColorManager colorManagerEF)
        {
            carManagerEF.Update(new Car { Id = 9, BrandId = 2, ColorId = 4, DailyPrice = 275000, ModelYear = "2014", Description = "Hızlı" });
            colorManagerEF.Update(new Color { Id = 4, Name = "Blue" });
            brandManagerEF.Update(new Brand { Id = 6, Name = "Ferrari S.p.A" });
        }


        private static void InMemoryTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            InMemoryCarDal inMemoryCarDal = new InMemoryCarDal();

            GetAllTest(inMemoryCarDal);
            Console.WriteLine("------");
            AddTestInMemory(inMemoryCarDal);
            Console.WriteLine("------");
            GetByIdTest(inMemoryCarDal);
            Console.WriteLine("------");
            inMemoryCarDal.Update(new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 800000, ModelYear = "1964", Description = "Retro Update" });

            Console.WriteLine("in memory");
            foreach (var car in carManager.GetByUnitPrice(40, 100).Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void GetByIdTest(InMemoryCarDal inMemoryCarDal)
        {
            Console.WriteLine(inMemoryCarDal.GetById(5).Description);
        }

        private static void AddTestInMemory(InMemoryCarDal inMemoryCarDal)
        {
            inMemoryCarDal.Add(new Car { Id = 8, BrandId = 8, ColorId = 8, DailyPrice = 800000, ModelYear = "1972", Description = "Yeni Retro" });

            foreach (var car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(
                "* Aciklama: {0} | Ücret: {1} | Yıl: {2} | Marka: {3} | Renk: {4} ", car.Description,
                car.DailyPrice,
                car.ModelYear,
                car.BrandId,
                car.ColorId);
            };
        }

        private static void GetAllTest(InMemoryCarDal inMemoryCarDal)
        {
            foreach (var car in inMemoryCarDal.GetAll())
            {
                Console.WriteLine(
                "* Aciklama: {0} | Ücret: {1} | Yıl: {2} | Marka: {3} | Renk: {4} ", car.Description,
                car.DailyPrice,
                car.ModelYear,
                car.BrandId,
                car.ColorId);
            }; ;
        }
    }
}
