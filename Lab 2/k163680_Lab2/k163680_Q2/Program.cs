using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k163680_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int numberOfThreads = 5;

            int[] array = new int[1000000];
            //max value for reducing range for higher probability of finding a number
            for (int i = 0; i < 1000000; i++)
                array[i] = random.Next(0, 100);


            Console.WriteLine("Enter any integer to search from array..");
            int searchNumber = int.Parse(Console.ReadLine());

            LinearSearch search = new LinearSearch();

            search.ParallelSearch(array, searchNumber, numberOfThreads);

            Console.ReadLine();
        }
    }
}
