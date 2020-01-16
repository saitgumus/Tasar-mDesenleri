using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    /// <summary>
    /// Concreate Strategy
    /// </summary>
    public class After2010 : CreditCalculator
    {
        public override void Calculate(double miktar, int taksit)
        {
            double monthly = ((miktar * 3 * taksit) / 1200);
            Console.WriteLine(string.Format("Ana para:{0} \n Taksit:{1} \n Aylık Ödeme:{2}\n Toplam Tutar:{3}",
                                              miktar, taksit,
                                              monthly + (miktar / taksit),
                                              monthly * taksit + miktar
                                              ));
        }
    }
}
