using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Safari : Browser
    {
        public override void Browse()
        {
            Console.WriteLine("Safari tarayıcısı çalıştı.");
        }
    }
}
