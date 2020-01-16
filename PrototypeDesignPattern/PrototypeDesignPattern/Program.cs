using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee emp = new Employee();
            emp.name = "employee Name";
            emp.surName = "employee Surname";

            Customer cus = emp.Clone() as Customer;
            cus.customerId = 123;
            cus.name = "customerName";
            cus.surName = "customer Surname";

            Console.WriteLine("Customer nesnesi Employee nesnesinden türetildi.");

            Console.WriteLine("employee sınıfı");
            Console.WriteLine(string.Concat("name:",emp.name));
            Console.WriteLine(string.Concat("surname:",emp.surName));

            Console.WriteLine("customer sınıfı");
            Console.WriteLine(string.Concat("name:", cus.name));
            Console.WriteLine(string.Concat("surname:", cus.surName));
            Console.WriteLine(string.Concat("customer Id:", cus.customerId));



            Console.ReadKey();
        }

        public abstract class Person
        {
            public abstract Person Clone();

            public string name { get; set; }
            public string surName { get; set; }
        }

        public class Customer : Person
        {
            public int customerId;

            public override Person Clone()
            {
                return this.MemberwiseClone() as Person;
            }
        }


        public class Employee : Person
        {
            
            public override Person Clone()
            {
                return this.MemberwiseClone() as Person;
            }
        }
    }
}
