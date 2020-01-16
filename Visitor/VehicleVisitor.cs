using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class VehicleVisitor : Visitor
    {
        public void visit(Tax tax)
        {
            if (tax is VehicleTax)
            {
                Console.WriteLine("Taşıt vergisi alındı.");
            }
            else
            {
                Console.WriteLine("Sadece Taşıt vergisi ödemesi yapabilirsiniz.");
            }
        }
    }
}
