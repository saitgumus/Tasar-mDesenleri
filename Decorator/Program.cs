using System;


namespace Decorator
{
    /// <summary>
    /// kullanım amacı itibariyle visitör deseni ile sıkça karıştırılan decoratör deseni sınıfın yapısında değişikliğe
    /// gitmeksizin belirli bir nesneye yeni ek fonksiyon ve özelliklerin dinmik oarak eklenmesi amacıyla kullanılır.
    /// *dikkat edilmesi gereken nokta, yeni özelliğin sınıfa değil, belirli bir nesneye kazandırılıyor olması. ve bu değişiklikten aynı
    /// sınıfa ilişkin diğer nesnelerin etkilenmiyor olması..
    ///
    /// *component: arayüzü veya soyut sınıfı kendisine yeni özellikler eklenilmek istenen nesneyi soyut anlamda ifade eder.^concreateComponent gibi
    /// sınıflarla somutlanmış şekilleri bulunur.
    /// *Decorator: desen için kilit rol oynar. üzerinde dekorasyon yapılmak istenilen nesnelerr için bir wrapper durumundadır.
    /// ^decorator sınıf dekorer edeceği nesnenin referansını içermelidir.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// senaryo
        /// bilgisayar mağazası uygulamamız var
        /// özel ödeme yöntemi dekore edildiğinde ürün yüzde 10 indirimli oluyor
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("");

            PCBase pC = new PersonPC { Brand= "lenovo", Model="A550", Price=4500 };
            SpecialOffer special = new SpecialOffer(pC);

            Console.WriteLine("normal ödeme");

            Console.WriteLine(pC.Price.ToString());

            Console.WriteLine("özel ödeme");
            Console.WriteLine(special.Price.ToString());

            Console.ReadKey();
        }

        #region component
        /// <summary>
        /// component
        /// </summary>
        abstract class PCBase
        {
            public abstract string Brand { get; set; }
            public abstract string Model { get; set; }
            public abstract double Price { get; set; }
        }


        class OfficePC : PCBase
        {
            public override string Brand { get; set; }
            public override string Model { get; set; }
            public override double Price { get; set; }

            public override string ToString()
            {
                return base.ToString();
            }
        }


        class PersonPC : PCBase
        {
            public override string Brand { get; set; }
            public override string Model { get; set; }
            public override double Price { get; set; }

            public override string ToString()
            {
                return base.ToString();
            }
        }

        #endregion

        #region Decorator

        /// <summary>
        /// decorator abs. sınıfı
        /// </summary>
        abstract class PCDecoratorBase : PCBase
        {
            private PCBase pCBase;

            protected PCDecoratorBase(PCBase _base)
            {
                pCBase = _base;
            }
        }

         class SpecialOffer : PCDecoratorBase
        {
            private readonly PCBase pC;
            public override string Brand { get { return pC.Brand; } set { } }
            public override string Model { get { return pC.Model; } set { } }
            public override double Price { get { return pC.Price * 0.9; } set { } }

            public SpecialOffer(PCBase pC) : base(pC)
            {
                this.pC = pC;
            }
        }

        #endregion


    }
}
