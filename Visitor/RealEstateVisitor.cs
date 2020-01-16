using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class RealEstateVisitor : Visitor
    {
        public void visit(Tax tax)
        {
           
            if (tax is RealEstateTax)
            {
                Console.WriteLine("emlak Odemesi alındı.");
            }
            else
            {
                Console.WriteLine("Sadece emlak vergisi ödemesi yapılabilir.");
            }
        }
    }
}
