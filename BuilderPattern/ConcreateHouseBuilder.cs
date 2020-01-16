using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ConcreateHouseBuilder : HouseBuilder
    {
        private House house;

        public ConcreateHouseBuilder()
        {
            this.house = new House();
        }
        public override void buildBasement()
        {
            house.setBasement("Beton ev zemini.");
        }

        public override void buildRoof()
        {
            house.setRoof("Beton dam.");
        }

        public override void buildStructure()
        {
            house.setStructure("Beton bloklar.");
        }

      
        public override House GetHouse()
        {
            return this.house;
        }
    }
}
