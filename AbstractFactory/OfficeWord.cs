using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class OfficeWord : OfficeProgram
    {
        public override void WriteSomeWord()
        {
            Console.WriteLine("Microsoft word ile yazıldı.");
        }
    }
}
