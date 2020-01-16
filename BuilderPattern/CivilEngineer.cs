using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class CivilEngineer
    {
        private HouseBuilder houseBuilder;
        public CivilEngineer(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public House GetHouse()
        {
            return this.houseBuilder.GetHouse();
        }

        public void constructHouse()
        {
            this.houseBuilder.buildBasement();
            this.houseBuilder.buildStructure();
            this.houseBuilder.buildRoof();
        }
    }
}
