using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class ScienceBook : Book
    {
        public override void borrowFromLibrary()
        {
            if (available)
            {
                Console.WriteLine("Bilim kitabı emanet alındı.");
                available = !available;
            }
            else
            {
                Console.WriteLine("Kitap müsait değil.");
            }
        }

        public override void returnToLibrary()
        {
            available = true;
        }
    }
}
