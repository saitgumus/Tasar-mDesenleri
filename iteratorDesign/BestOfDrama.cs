using System;
using System.Collections;
using System.Collections.Generic;


namespace iteratorDesign
{ 
    public class BestOfDrama : IEnumerator
    {
    private List<BookInfo> besatOfDrama;
        private int counter;

        public BestOfDrama()
        {
            besatOfDrama = new List<BookInfo>();
            counter = 0;
            besatOfDrama.Add(new BookInfo { Name = "Drama1", Type = (int)BookTypes.drama });
            besatOfDrama.Add(new BookInfo { Name = "Drama2", Type = (int)BookTypes.drama });
            besatOfDrama.Add(new BookInfo { Name = "Drama3", Type = (int)BookTypes.drama });
            besatOfDrama.Add(new BookInfo { Name = "Drama4", Type = (int)BookTypes.drama });
            besatOfDrama.Add(new BookInfo { Name = "Drama5", Type = (int)BookTypes.drama });
            besatOfDrama.Add(new BookInfo { Name = "Drama6", Type = (int)BookTypes.drama });
            besatOfDrama.Add(new BookInfo { Name = "Drama7", Type = (int)BookTypes.drama });
            besatOfDrama.Add(new BookInfo { Name = "Drama8", Type = (int)BookTypes.drama });

        }

        public object Current => besatOfDrama[counter++];

        public bool MoveNext()
        {
            if(counter < besatOfDrama.Count)
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
