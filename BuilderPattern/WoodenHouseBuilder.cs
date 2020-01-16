using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class WoodenHouseBuilder : HouseBuilder
    {
        private House house;

        public WoodenHouseBuilder()
        {
            this.house = new House();
        }
        public override void buildBasement()
        {
            house.setBasement("Ahşap ev zemini.");
        }

        public override void buildRoof()
        {
            house.setRoof("Ahşap çatı.");
        }

        public override void buildStructure()
        {
            house.setStructure("Ahşap bloklar.");
        }

        public override House GetHouse()
        {
            return this.house;
        }
    }
}
