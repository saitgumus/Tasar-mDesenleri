using System;
using System.Collections;
using System.Linq;

namespace iteratorDesign
{
    public class BestOfScience : IEnumerator
    {
        private BookInfo[] bestOfScience;
        private int counter;

        public BestOfScience()
        {
            bestOfScience = new BookInfo[10];
            counter = 0;
            bestOfScience[0] = (new BookInfo { Name = "Science1", Type = (int)BookTypes.drama });
            bestOfScience[1] = (new BookInfo { Name = "Science2", Type = (int)BookTypes.drama });
            bestOfScience[2] = (new BookInfo { Name = "Science3", Type = (int)BookTypes.drama });
            bestOfScience[3] = (new BookInfo { Name = "Science4", Type = (int)BookTypes.drama });
            bestOfScience[4] = (new BookInfo { Name = "Science5", Type = (int)BookTypes.drama });
            bestOfScience[5] =  (new BookInfo { Name = "Science6", Type = (int)BookTypes.drama });
            bestOfScience[6] = (new BookInfo { Name = "Science7", Type = (int)BookTypes.drama });
            bestOfScience[7] = (new BookInfo { Name = "Science8", Type = (int)BookTypes.drama });

        }

        public object Current => bestOfScience[counter++];

        public bool MoveNext()
        {
            if (counter < bestOfScience.Length-1 && Current != null)
            {
                return true;
            }

            return false;
        }

        public void Reset()
        {
            counter = 0;
        }
    }
}
