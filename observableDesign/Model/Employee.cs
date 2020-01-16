using System;
namespace observerDesign
{
    public class Employee  : Observer
    {
        public Employee()
        {
        }

        public void Notify(string message)
        {
            Console.WriteLine("Değerli Çalışanımız, ");
            Console.WriteLine(message);
        }
    }
}
