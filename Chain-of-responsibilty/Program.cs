using System;

namespace Chain_of_responsibilty
{
    class Program
    {
        static void Main(string[] args)
        {
            Consultant consultant = new Consultant();
            consultant.RentRoom();
            consultant.RentRoom();
            consultant.RentRoom();
            consultant.RentRoom();



            Console.ReadLine();
        }
    }
}
