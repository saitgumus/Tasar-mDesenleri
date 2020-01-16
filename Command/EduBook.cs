using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class EduBook : Book
    {

        public override void borrowFromLibrary()
        {
            if (available)
            {
                Console.WriteLine("Bilgisayar kitabı emanet alındı.");
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
