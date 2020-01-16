using System;

namespace BuilderPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            HouseBuilder concreateHouse = new ConcreateHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(concreateHouse);

            engineer.constructHouse();

            House house = engineer.GetHouse();



            Console.ReadKey();
        }
    }
}
