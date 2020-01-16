using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    /// <summary>
    /// Strategy Class
    /// </summary>
    public abstract class CreditCalculator
    {
        public abstract void Calculate(double miktar, int taksit);
    }
}
