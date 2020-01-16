using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Apple");
            IComputer apple = new productComputer().CreateComputer(Brands.Apple);

            apple.start();
            apple.loadSoftware();
            apple.packing();
            apple.serve();

            Console.WriteLine(" Samsung ");
            IComputer samsung = new productComputer().CreateComputer(Brands.Samsung);
            samsung.start();
            samsung.loadSoftware();
            samsung.packing();
            samsung.serve();

            Console.WriteLine(" Lenovo");
            IComputer lenovo = new productComputer().CreateComputer(Brands.Lenovo);
            lenovo.start();
            lenovo.loadSoftware();
            lenovo.packing();
            lenovo.serve();



            Console.ReadKey();
        }
    }


}
