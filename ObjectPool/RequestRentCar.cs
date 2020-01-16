using System;
namespace ObjectPool
{
    public class RequestRentCar : RentalCar
    {
        public override void Rent()
        {
            Console.WriteLine("Arac kiralandı.");
        }
    }
}
