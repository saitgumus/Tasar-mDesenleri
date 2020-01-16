using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public class VehicleTax : Tax
    {
        public VehicleTax(int pay) : base(pay) { }
        public override void Accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}
