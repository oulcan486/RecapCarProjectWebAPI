using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarDetail();
            // CarTest();
            // BrandTest();
            //ColorTest();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            DateTime date = new DateTime(2021, 7, 20, 0, 0, 0);
            DateTime returndate = new DateTime(2021, 8, 23, 0, 0, 0);
            Rental ahmet = new Rental { CarId = 5, CustomerId = 4, RentDate = date, ReturnDate = returndate };
            var rentcar = rentalManager.Add(ahmet);
            
                if ( rentcar.Success==false)
                {
                    Console.WriteLine(rentcar.Message);
                }
                else
                {
                    Console.WriteLine(rentcar.Message);
                }
            
            Console.ReadKey();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color blue = new Color { Id=1003, Name = "Grey" };
            var result = colorManager.Delete(blue);
            var All = colorManager.GetAll();
            if (result.Success==true)
            {
                foreach (var a in All.Data)
                {
                    Console.WriteLine(a.Name);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            //Console.WriteLine(result.Name);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand dacia = new Brand {Id=1005, Name = "Dacia" };
           // brandManager.Delete(dacia);
            var result = brandManager.GetById(3);
            if (result.Success==true)
            {
                

               
                    Console.WriteLine(result.Data.Name);
                
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
            
            Console.ReadKey();
        }

        private static void CarDetail()
        {
            CarManager carManagerDetail = new CarManager(new EfCarDal());
            foreach (var c in carManagerDetail.GetCarDetails().Data)
            {
                Console.WriteLine("Markası: {0} ,Adı:{1} , Renk:{2} ,Günlük Ücreti:{3}", c.BrandName, c.CarName, c.ColorName, c.DailyPrice);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car chewrolet = new Car { BrandId = 1004, ColorId = 1, DailyPrice = 1000, Description = "Spark", ModelYear = "2015" };
            var result = carManager.Add(chewrolet);
            if (result.Success==true)
            {
                Console.WriteLine(result.Message);
                foreach (var c in carManager.GetAll().Data)
                {
                    Console.WriteLine(c.Description);
                }
            }
            else
            {
                Console.WriteLine("Eklenemedi");
            }
            
            //Console.WriteLine(carManager.Add(chewrolet).Message);
            /* foreach (var c in carManager.GetCarsByColorId(2))
             {
                 Console.WriteLine("{0}, {1}, {2}, {3}, {4},{5}" , c.Id, c.ColorId, c.BrandId, c.DailyPrice, c.Description,c.ModelYear);
             }*/
           /* foreach (var c in carManager.GetAll().Data)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", c.ColorId, c.BrandId, c.DailyPrice, c.Description, c.ModelYear);
            }*/
        }
    }
}
