using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    /// <summary>
    /// context
    /// </summary>
    public class Customer
    {
        public CreditCalculator CreditCalculator { get; set; }
        public void SaveCredit(double miktar, int taksit)
        {
            Console.WriteLine("kredi hesaplama:\n");
            CreditCalculator.Calculate(miktar, taksit);
        }
    }
}
