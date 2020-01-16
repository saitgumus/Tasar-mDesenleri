using System;
namespace Mediatoradesign
{
    public class ASPDeveloper : Developer
    {
       
        public ASPDeveloper(string name):base(name)
        {
            base.userName = name;
        }

        public override void Notify(string message)
        {
            Console.WriteLine("ASP Developer için mesaj alındı: " + message);
        }
    }
}
