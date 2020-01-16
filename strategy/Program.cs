using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    class Program
    {
        /// <summary>
        /// senaryo: bir bankada kredi hesaplama süreci
        /// bir iş katmanında belli bir mevzuata göre belli bir hesaplama;
        /// bir müşteriye kredi verilecek:
        /// eğer müşteri 2010dan önce müşteri olmuşsa başka bi hesaplama
        /// 2010'dan sonra müşteri olmuşsa farklı bir hesaplama gerçekleşecek
        /// yani bir bankanın farklı kredi tiplerine farklı hesaplama süreci
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("2010 öncsi müşteri");
            customer.CreditCalculator = new Before2010();
            customer.SaveCredit(200, 12);


            Console.WriteLine("\n 2010 sonrası müşteri");
            customer.CreditCalculator = new After2010();
            customer.SaveCredit(200, 12);

            Console.ReadKey();
        }
    }
}
