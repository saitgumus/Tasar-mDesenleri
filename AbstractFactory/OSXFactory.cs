using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class OSXFactory : SoftwareFactory
    {
        public override Browser GetBrowser()
        {
            return new Safari();
        }

        public override OfficeProgram GetOfficeProgram()
        {
            return new Pages();
        }
    }
}
