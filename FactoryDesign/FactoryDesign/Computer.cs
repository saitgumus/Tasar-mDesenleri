using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public interface IComputer
    {
        void start();
        void packing();
        void loadSoftware();
        void serve();
    }

    public class Apple : IComputer
    {

        public void start()
        {
            Console.WriteLine("Apple markalı bilgisayar hazırlanıyor...");
        }
        public void loadSoftware()
        {
            Console.WriteLine(" MacOs yazılımı Yükeniyor..");
        }

        public void packing()
        {
            Console.WriteLine("bilgisayar paketleniyor..");
        }

        public void serve()
        {
            Console.WriteLine("Apple markalı bilgisayar hazır.");
        }
    }

    public class Samsung : IComputer
    {

        public void start()
        {
            Console.WriteLine("Samsung bilgisayar hazırlanıyor...");
        }
        public void loadSoftware()
        {
            Console.WriteLine("Windows Yazılım Yükeniyor..");
        }

        public void packing()
        {
            Console.WriteLine("Samsung bilgisayar paketleniyor..");
        }

        public void serve()
        {
            Console.WriteLine("Samsung bilgisayar hazır.");
        }
    }


        public class Lenovo : IComputer
        {

            public void start()
            {
                Console.WriteLine("Lenovo markalı bilgisayar hazırlanıyor...");
            }
            public void loadSoftware()
            {
                Console.WriteLine("Yazılım Yükeniyor..");
            }

            public void packing()
            {
                Console.WriteLine("Lenovo markalı bilgisayar paketleniyor..");
            }

            public void serve()
            {
                Console.WriteLine("Lenovo bilgisayar hazır.");
            }
        }
    }
