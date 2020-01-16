using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class BorrowCommand : Command
    {
        private List<Book> list = new List<Book>();

        public void GetBook(Book book)
        {
            this.list.Add(book);
        }

        public void ReturnBook(Book book)
        {
            if (this.list.Contains(book))
            {
                this.list.Remove(book);
            }
            else
            {
                Console.WriteLine("Bu kitap emanette değil.");
            }
        }
        public void execute()
        {
            list.ForEach(r => r.borrowFromLibrary());
        }
    }
}
