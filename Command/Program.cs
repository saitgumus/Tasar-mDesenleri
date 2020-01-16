using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            ScienceBook scienceBook = new ScienceBook();
            EduBook eduBook = new EduBook();

            BorrowCommand borrowCommand = new BorrowCommand();
            borrowCommand.GetBook(eduBook);
            borrowCommand.GetBook(scienceBook);
            borrowCommand.ReturnBook(scienceBook);
            borrowCommand.execute();
            borrowCommand.GetBook(scienceBook);
            borrowCommand.GetBook(eduBook);
            borrowCommand.execute();

            Console.ReadKey();
        }
    }
}
