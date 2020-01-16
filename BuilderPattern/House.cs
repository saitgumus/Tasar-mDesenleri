using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class House : HousePlan
    {
        private string basement;
        private string structure;
        private string roof;
        private string interior;
        public override void setBasement(string basement)
        {
            this.basement = basement;
        }

        public override void setRoof(string roof)
        {
            this.roof = roof;
        }

        public override void setStructure(string structure)
        {
            this.structure = structure;
        }
    }
}
