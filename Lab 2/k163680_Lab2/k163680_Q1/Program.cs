using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace k163680_Q1
{
    class Program
    {


        static void Main(string[] args)
        {
            Random random = new Random();
            const int numberOfThreads = 5;

            int[] array = new int[1000000];
            //max value for reducing range for higher probability of finding a number
            for(int i=0; i< 1000000; i++)
                array[i] = random.Next(0,10000000);
                

            Console.WriteLine("Enter any integer to search from array..");
            int searchNumber = int.Parse(Console.ReadLine());
            LinearSearch search = new LinearSearch();
            
            Thread simpleSearch = new Thread(()=>search.Search(array, searchNumber));
            Thread parallelSearch = new Thread(() => search.ParallelSearch(array, searchNumber, numberOfThreads));

            simpleSearch.Start();
            parallelSearch.Start();

            simpleSearch.Join();
            parallelSearch.Join();

            Console.ReadLine();


        }
    }
}
