using System;
using System.Collections;

namespace iteratorDesign
{
    public class ScienceBook : IterableBook
    {
        public ScienceBook()
        {
        }

        public IEnumerator GetEnumerator()
        {
            return new BestOfScience();
        }

    }
}
