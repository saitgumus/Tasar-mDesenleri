using System;
using System.Collections.Generic;

namespace ObjectPool
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Havuzun boyutu {0}", CarPool.Instance.size);


            Console.WriteLine("Bir araç kiralıyoruz.");
            var car1 = CarPool.Instance.AcquireObject();

            car1.Rent();

            Console.WriteLine("Aracı geri bırakıyoruz");
            if (car1 != null)
                CarPool.Instance.ReleaseObject(car1);

            var cars = new List<RentalCar>();
            for (int i = 0; i < CarPool.Instance.size; i++)
            {
                cars.Add(CarPool.Instance.AcquireObject());
            }

            Console.WriteLine("Uygun olan tüm araçlar kiralandı.");

            var nullClient = CarPool.Instance.AcquireObject();

            if (nullClient == null)
                Console.WriteLine("Daha fazla kiralık araç bulunmamaktadır.");

            Console.WriteLine("Kiralık araç sayısını artırıyoruz.");
            CarPool.Instance.IncreaseSize();

            Console.WriteLine("Yeni bir araç kiralıyoruz.");
            var newCar = CarPool.Instance.AcquireObject();

            newCar.Rent();

            Console.WriteLine("Aracı geri bırakıyoruz.");
            if (newCar != null)
                CarPool.Instance.ReleaseObject(newCar);

            Console.WriteLine("Listedeki tüm araçları geri bırakıyoruz.");

            foreach (var item in cars)
                CarPool.Instance.ReleaseObject(item);

            Console.ReadKey();
        }
    }
}
