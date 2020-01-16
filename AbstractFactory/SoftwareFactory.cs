using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
   public abstract class SoftwareFactory
    {
        public abstract Browser GetBrowser();
        public abstract OfficeProgram GetOfficeProgram();

    }
}
