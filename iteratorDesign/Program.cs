using System;

namespace iteratorDesign
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            IterableBook iterableBook = new EducationBook();
            var bestOfEducation = iterableBook.GetEnumerator();

            while (bestOfEducation.MoveNext())
            {
                BookInfo book = bestOfEducation.Current as BookInfo;

                Console.WriteLine(book.Name);
            }

            iterableBook = new ScienceBook();
            var bestOfScience = iterableBook.GetEnumerator();

            while (bestOfScience.MoveNext())
            {
                BookInfo book = bestOfScience.Current as BookInfo;

                Console.WriteLine(book.Name);
            }

            iterableBook = new DramaBook();

            var bestOfDrama = iterableBook.GetEnumerator();

            while (bestOfDrama.MoveNext())
            {
                BookInfo book = bestOfDrama.Current as BookInfo;

                Console.WriteLine(book.Name);
            }

            Console.ReadKey();

        }
    }
}
