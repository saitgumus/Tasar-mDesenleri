using System;

namespace Facade
{
    /// <summary>
    /// bir kütüphane ve ya frameworkün kullanacak olan kişilere algı kolaylığı sağlamak amacıyla kütüphaneye facade sınıfı eklenir.
    /// kullanıcılar ise bu facade sınıfı üzerinden kütüphanedeki diğer nesnelere erişirler.
    /// *Facade bir başka bakış açısıyla kütüphane için ortak bir I/O birimidir.
    /// facade sınıfları katmanların birbirinden soyutlanmasına böylece katmanların birbirine gevşek bağlanmasına hizmet eder.
    /// facade sınıflar genellikle kendi içerisinde Singleton olarak tasarlanırlar.
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var searchFacade = new SearchEngineFacade();
            var results = searchFacade.GetSearchingResults("test sorgu ");

            Console.WriteLine(results);


            Console.ReadKey();
        }
    }



}
