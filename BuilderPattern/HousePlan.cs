using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class HousePlan
    {
        public abstract void setBasement(String basement);
        public abstract void setStructure(String structure);
        public abstract void setRoof(String roof);
    }
}
