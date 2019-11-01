using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k163680_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Enter size of a matrix..");
            int rows = Convert.ToInt32(Console.ReadLine());
        
            int[,] array = new int[rows, rows];
            for (int i=0; i < rows; i++)
            {
                for(int j=0; j< rows; j++)
                {
                    array[i,j] = random.Next(1, 1000);
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
            long sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if(i>=j)
                        sum += array[i, j];
                }
            }
            Console.WriteLine($"The sum of left diagonals is {sum}..");
            Console.ReadLine();


        }
    }
}
