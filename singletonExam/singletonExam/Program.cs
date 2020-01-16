using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletonExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = Country.CreateCountry();
            country.Name = "Turkey";

            Console.WriteLine("country class name : " + country.Name);
            Console.WriteLine(country.Name);

            Country newCountry = Country.CreateCountry();
            newCountry.Name = "ABD";

            Console.WriteLine("country class name : " + country.Name);
            Console.WriteLine("newCountry class name: " + newCountry.Name);


            Person person = new Person();
            person.country = Country.CreateCountry();
            person.country.Name = "Turkey";
            person.name = "Emre";
            person.surname = "Memil";

             Person person2 = new Person();
            person.country = Country.CreateCountry();
            person.name = "ömer";
            person.surname = "okul";


            Console.Read();
        }
    }



    public class Country
    {
        private static Country country;
        private static string name;
        private Country() { } 

        public static Country CreateCountry()
        {
            if (country == null)
                country = new Country();

            return country;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

    }

    public class Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public Country country;
    }
    
}
