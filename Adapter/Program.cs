using System;
using Adapter.bank;

namespace Adapter
{
    class MainClass
    {
        /// <summary>
        /// farklı sistemlerin kendi sistemlerimize entegre edilmesi durumunda kullanılır.
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

             Abank abank = new Abank();
            TBank ticaretBank = new TBank();

            KatılımAdapter katılımAdapter = new KatılımAdapter(abank);

            Console.WriteLine("katılım bankası..");
            abank.KrediSorgula();
            abank.KatılımPayıHesapla();

            Console.WriteLine("ticaret bankası..");
            ticaretBank.KobiDestekSorgula();

            // toy duck behaving like a bird  
            Console.WriteLine("katılım adapter...");
            katılımAdapter.KobiDestekSorgula();
        }
    }
}
