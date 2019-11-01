using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace k163680_Q2
{
    class LinearSearch
    {
        
        private bool Search(int[] array, int searchNumber, int loopCount, int numberOFThreads)
        {
            int startIndex = (array.Length / numberOFThreads) * loopCount;
            int endIndex = 0;
            
            if (numberOFThreads != loopCount + 1)
                endIndex = startIndex + (array.Length / numberOFThreads);
            else
                endIndex = array.Length;

            for (int i = startIndex; i < endIndex; i++)
            {
                if (array[i] == searchNumber)
                    return true;
            }
            return false;
        }


        public void ParallelSearch(int[] array, int searchNumber, int numberOFThreads)
        {
            System.Diagnostics.Stopwatch watch = System.Diagnostics.Stopwatch.StartNew();
            Task[] tasks = new Task[numberOFThreads];
            bool[] found = new bool[numberOFThreads];

            for (int i=0; i < numberOFThreads ; i++){
                Thread th = new Thread(() => { found[i] = Search(array, searchNumber, i, numberOFThreads); });
                th.Start();
                th.Join();

                if (found[i] == true)
                    break;
            }

            watch.Stop();
            foreach (bool item in found)
            {
                if (item == true)
                {
                    Console.WriteLine($"ParallelSearch: Found in {watch.ElapsedMilliseconds} milliseconds.. ");

                    return;
                }
            }
            Console.WriteLine($"SimpleSearch: Not found in {watch.ElapsedMilliseconds} milliseconds.. ");
            return;

        }
    }
}
