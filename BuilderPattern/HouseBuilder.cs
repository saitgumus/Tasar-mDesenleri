using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
   public abstract class HouseBuilder
    {
        public abstract void buildBasement();
        public abstract void buildStructure();
        public abstract void buildRoof();
        public abstract House GetHouse();
    }
}
