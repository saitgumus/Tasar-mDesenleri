using System;
namespace Facade.SearchEngine
{
    public class RetrievingData
    {
        public RetrievingData()
        {
        }

        public void GetData(int[] indexes)
        {
            Console.WriteLine("indiriliyor :  ");
            foreach (var item in indexes)
            {
                Console.WriteLine(item+", ");
            }
        }
    }
}
