using System;

namespace Visitor
{
    public class RealEstateTax : Tax
    {
        public override void Accept(Visitor visit)
        {
            visit.visit(this);
        }
        public RealEstateTax(int pay):base(pay)
        {
        }

    }
}