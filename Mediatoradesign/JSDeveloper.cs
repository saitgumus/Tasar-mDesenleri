using System;
namespace Mediatoradesign
{
    public class JSDeveloper : Developer
    {
        public JSDeveloper(string name):base(name)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("JS Developer mesajı alındı: " + message);
        }
    }
}
