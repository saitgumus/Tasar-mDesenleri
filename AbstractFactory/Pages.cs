using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Pages : OfficeProgram
    {
        public override void WriteSomeWord()
        {
            Console.WriteLine("Pages ile yazıldı.");
        }
    }
}
