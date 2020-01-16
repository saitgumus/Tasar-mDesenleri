using System;
using System.Collections;

namespace iteratorDesign
{
    public class EducationBook : IterableBook
    {
        public EducationBook()
        {
        }

        public IEnumerator GetEnumerator()
        {
            return new BestOfEducation();
        }
    }
}
