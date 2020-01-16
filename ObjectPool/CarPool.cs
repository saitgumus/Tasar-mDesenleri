using System;
using System.Collections.Concurrent;

namespace ObjectPool
{
    public class CarPool
    {

        private static Lazy<CarPool> carPool = new Lazy<CarPool>(() => new CarPool());
        public static CarPool Instance { get; } = carPool.Value;
        public int size { get { return currentSize; } }

        private const int defaultSize = 5;
        private ConcurrentBag<RentalCar> bag = new ConcurrentBag<RentalCar>();
        private volatile int currentSize;
        private volatile int counter;
        private object lockObject = new object();

        
        private CarPool() : this(defaultSize)
        {
        }

        private CarPool(int size)
        {
            currentSize = size;
        } 

        public RentalCar AcquireObject()
        {
            if (!bag.TryTake(out RentalCar item))
            {
                lock (lockObject)
                {
                    if (item == null)
                    {
                        if (counter >= currentSize)
                            return null;

                        item = new RequestRentCar();
                        counter++;
                        Console.WriteLine("Yeni Araç Kiralandı.");
                    }
                }

            }

            return item;
        }

        public void ReleaseObject(RentalCar item)
        {
            bag.Add(item);
        }

        public void IncreaseSize()
        {
            lock (lockObject)
            {
                currentSize++;
            }
        }
    }
}
