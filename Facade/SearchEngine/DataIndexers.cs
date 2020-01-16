using System;
namespace Facade.SearchEngine
{
    public class DataIndexers
    {
        public DataIndexers()
        {
        }

        public int[] GetIndexesOfStoreData(string query)
        {
            Console.WriteLine($"{query} can be found at index: 1, 5, 8");
            return new int[] { 1, 5, 8 };
        }
    }
}
