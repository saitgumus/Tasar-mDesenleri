using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class PayTax
    {
        public static void PayRealEstate(Tax tax)
        {
            tax.Accept(new RealEstateVisitor());
        }

        public static void PayVehicleEstate(Tax tax)
        {
            tax.Accept(new VehicleVisitor());
        }
    }
}
