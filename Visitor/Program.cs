using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Tax etax = new RealEstateTax(123);
            Tax vtax = new VehicleTax(222);

            PayTax.PayRealEstate(etax);
            PayTax.PayVehicleEstate(etax);

            PayTax.PayRealEstate(vtax);
            PayTax.PayVehicleEstate(vtax);
            
            Console.ReadKey();
        }
    }
}
