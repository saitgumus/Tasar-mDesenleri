using System;
namespace observerDesign
{
    public class Customer : Observer
    {
        public Customer()
        {
        }

        public void Notify(string message)
        {
            Console.WriteLine("Değerli Müşterimiz, ");
            Console.WriteLine(message);
        }
    }
}
