using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k163680_Q1
{
    class LinearSearch
    {
        public void Search(int[] array , int searchNumber )
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (int integer in array)
            {
                if (searchNumber == integer)
                {
                    watch.Stop();
                    Console.WriteLine($"SimpleSearch: Found in {watch.ElapsedMilliseconds} milliseconds.. ");
                    return;
                }
            }
            watch.Stop();
            Console.WriteLine($"SimpleSearch: Not found in {watch.ElapsedMilliseconds} milliseconds.. ");

            return;
        }
        private bool Search(int[] array ,int searchNumber,int loopCount, int numberOFThreads)
        {
            int startIndex = (array.Length / numberOFThreads)* loopCount;
            int endIndex = 0;
            if (numberOFThreads!= loopCount+1)
                endIndex = startIndex + (array.Length / numberOFThreads);
            else
                endIndex = array.Length;

            for (int i = startIndex; i<endIndex; i++)
            {
                if(array[i] == searchNumber)
                    return true;
            }
            return false;
        }


        public void ParallelSearch(int[] array, int searchNumber,int numberOFThreads)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            bool[] found = new bool[numberOFThreads];
            

            Parallel.For(0, numberOFThreads, i => {

                found[i] = Search(array,searchNumber,i, numberOFThreads);
                
            });
            watch.Stop();
            foreach (bool item in found)
            {
                if (item == true)
                {
                    Console.WriteLine($"ParallelSearch: Found in {watch.ElapsedMilliseconds} milliseconds.. ");

                    return;
                }
            }
            Console.WriteLine($"ParallelSearch: Not found in {watch.ElapsedMilliseconds} milliseconds.. ");
            return;

        }
    }
}
