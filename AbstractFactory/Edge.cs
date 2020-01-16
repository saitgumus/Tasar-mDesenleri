using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Edge : Browser
    {
        public override void Browse()
        {
            Console.WriteLine("Edge tarayıcısı çalıştı.");
        }
    }
}
