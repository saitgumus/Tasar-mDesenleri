using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibilty
{
    public class Room
    {
        public bool Status { get; set; }
        public int Number { get; private set; }

        private Room nextRoom;

        public Room NextRoom
        {
            get { return nextRoom; }
            set { nextRoom = value; }
        }
        public Room(int number)
        {
            this.Number = (number<0)? 0:number;
        }

        public void getRoom()
        {
            if (!Status)
            {
                Status = true;
                Console.WriteLine(string.Format("{0} numaralı oda kiralandı.",this.Number) );
            }
            else
            {
                if (NextRoom != null)
                    NextRoom.getRoom();
                else
                    Console.WriteLine("Başka Oda Kalmadı.");
            }

        }
    }
}
