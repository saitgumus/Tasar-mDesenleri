using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public abstract class Book
    {
        public bool available = true;

       public abstract void borrowFromLibrary();

        public abstract void returnToLibrary();

    }
}
