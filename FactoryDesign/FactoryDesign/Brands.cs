using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public enum Brands
    {
        Apple = 1,
        Samsung = 2,
        Lenovo = 3
    }
    
    class productComputer
    {
        public IComputer CreateComputer(Brands brand)
        {
            IComputer computer = null;

            switch (brand)
            {
                case Brands.Apple:
                    computer = new Apple();
                    break;
                case Brands.Samsung:
                    computer = new Samsung();
                    break;
                case Brands.Lenovo:
                    computer = new Lenovo();
                    break;
                default:
                    break;
            }

            return computer;
        }
    }
}
