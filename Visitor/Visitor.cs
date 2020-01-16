using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface Visitor
    {
        abstract void visit(Tax tax);
    }
}
