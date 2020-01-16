using System;

namespace Bridge
{
    /// <summary>
    /// Model güdümlü programlama çerçevesinde problem alanındaki varıklar soyutlanarak modellenir.
    /// buvarlıkların sayısı çok fazla ve aralarındaki bağlatı oldukça karmaşık olabilir.bu durum ortaya konulmak istenen modeli çıkmaza sokabilir.
    /// bundan kurtulmanın yolu ise bridge deseni ile mümkündür.
    /// *Abstraction soyut sınıfı ya da interface'i modellenen olguyu soyutlamak için kullanılır.
    /// *RefinedAbstraction: Abstraction soyut sınıfından türeyen bu sınıf Implementor interface’ine ilişkin bir referans tutarak kendi implementasyonunu
    /// hangi ConcreteImplementor’un gerçekleştireceğini bilir.
    /// *Implemetor: Farklı ConcreteImplementor sınıfları için ortak bir arayüzdür.
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CustomerManager customerManager = new CustomerManager();
            customerManager.MessageSender = new MailSender();

            customerManager.UpdateCustomer();

            customerManager.MessageSender = new SmsSender();

            customerManager.UpdateCustomer();


            Console.ReadKey();
        }
    }


    /// <summary>
    /// Abstraction
    /// </summary>
    abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Mesaj kaydedildi.");
        }

        public abstract void Send(Information i);
    }


    class MailSender : MessageSenderBase
    {
        public override void Send(Information i)
        {
            Console.WriteLine("mail gönderildi. \n baslık: {0} \n text: {1}",i.Title,i.Text);
        }
    }

    class SmsSender : MessageSenderBase
    {
        public override void Send(Information i)
        {
            Console.WriteLine("SMS gönderildi. \n baslık: {0} \n text: {1}", i.Title, i.Text);
        }
    }


    class Information
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }



    //...
    class CustomerManager
    {
        public MessageSenderBase MessageSender { get; set; }

        public void UpdateCustomer()
        {
            MessageSender.Send(new Information { Title = "Güncelleme", Text = " müşteri güncellemesi yapıldı. " });
        }

    }

}
