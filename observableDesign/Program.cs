using System;

namespace observerDesign
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {
            Observer ali = new Employee();
            Observer veli = new Customer();

            NoticeObservable notice = new NoticeObservable();

            notice.AddUser(ali);
            notice.AddUser(veli);

            notice.Notify(" sizi tanımak güzel. ");

            notice.RemoveUser(veli);

            notice.Notify("Bizimle kaldığınız için teşekkür ederiz.");


            Console.ReadKey();
        }
    }
}
