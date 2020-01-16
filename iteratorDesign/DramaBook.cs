using System;
using System.Collections;

namespace iteratorDesign
{
    public class DramaBook : IterableBook
    {
        public DramaBook()
        {
        }

        public IEnumerator GetEnumerator()
        {
            return new BestOfDrama();
        }
    }
}
