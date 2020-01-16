using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftwareFactory software = FactoryUtil.GetSoftware("osx");
            software.GetBrowser().Browse();
            software.GetOfficeProgram().WriteSomeWord();

            software = FactoryUtil.GetSoftware("windows");
            software.GetBrowser().Browse();
            software.GetOfficeProgram().WriteSomeWord();

            Console.ReadKey();
        }
    }
}
