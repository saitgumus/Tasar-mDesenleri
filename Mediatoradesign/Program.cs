using System;
using System.IO;

namespace Mediatoradesign
{
    class MainClass
    {
        public static void Yaz(string message)
        {
            Console.WriteLine(message);
        }

        public static void Main(string[] args)
        {
            Yaz("Mediator Design..");
            Developer emre = new ASPDeveloper("emre");
            Developer sait = new ASPDeveloper("sait");
            Developer omer = new JSDeveloper("Omer");

            Project web = new WebProject("web projesi.");
            web.AddDeveloper(emre);
            web.AddDeveloper(sait);
            web.AddDeveloper(omer);
            web.sendBroadcast("herkese merhaba");

            web.checkIn(sait, "alsdefpefasfjffghjklşnbvcyuıop");
            web.sendMessageToDev(emre, "check-in yaptım kodları inceleyebilir misin?");

            web.checkIn(emre, "woepojwıoasoneşlfasosakak");
            web.sendMessageToDev(sait, " değiştirdim hepsini :D  ");



            Console.ReadKey();
        }
    }

}
