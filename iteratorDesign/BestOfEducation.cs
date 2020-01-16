using System;
using System.Collections;
using System.Collections.Generic;

namespace iteratorDesign
{
    public class BestOfEducation : IEnumerator
    {
        private ArrayList bestOfEducation;
        private int counter;

        public BestOfEducation()
        {
            bestOfEducation = new ArrayList();
            counter = 0;
            bestOfEducation.Add(new BookInfo { Name = "Education1", Type = (int)BookTypes.drama });
            bestOfEducation.Add(new BookInfo { Name = "Education2", Type = (int)BookTypes.drama });
            bestOfEducation.Add(new BookInfo { Name = "Education3", Type = (int)BookTypes.drama });
            bestOfEducation.Add(new BookInfo { Name = "Education4", Type = (int)BookTypes.drama });
            bestOfEducation.Add(new BookInfo { Name = "Education5", Type = (int)BookTypes.drama });
            bestOfEducation.Add(new BookInfo { Name = "Education6", Type = (int)BookTypes.drama });
            bestOfEducation.Add(new BookInfo { Name = "Education7", Type = (int)BookTypes.drama });
            bestOfEducation.Add(new BookInfo { Name = "Education8", Type = (int)BookTypes.drama });

        }

        public object Current => bestOfEducation[counter++];

        public bool MoveNext()
        {
            if (counter < bestOfEducation.Count)
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
