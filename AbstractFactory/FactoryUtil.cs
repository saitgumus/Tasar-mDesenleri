using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class FactoryUtil
    {
        public static SoftwareFactory GetSoftware(string softName)
        {
            if(softName.ToLower() == "osx")
            {
                return new OSXFactory();
            }

            if(softName.ToLower() == "windows")
            {
                return new WindowsFactory();
            }

            throw new Exception("İsletim sistemi bulunamadı.");

        }
    }
}
