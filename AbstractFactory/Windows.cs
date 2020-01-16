using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class WindowsFactory : SoftwareFactory
    {
        public override Browser GetBrowser()
        {
            return new Edge();
        }

        public override OfficeProgram GetOfficeProgram()
        {
            return new OfficeWord();
        }
    }
}
