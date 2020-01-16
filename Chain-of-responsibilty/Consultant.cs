using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibilty
{
    public class Consultant
    {

        private List<Room> rooms = new List<Room>();

        public Consultant()
        {
            Room r1 = new Room(1);
            Room r2 = new Room(2);
            Room r3 = new Room(3);

            r1.NextRoom = r2;
            r2.NextRoom = r3;

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
        }

        public void RentRoom()
        {
            rooms[0].getRoom();
        }

    }
}
