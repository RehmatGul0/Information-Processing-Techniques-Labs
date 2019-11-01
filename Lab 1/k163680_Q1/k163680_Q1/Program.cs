using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k163680_Q1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string..");
            String str = Console.ReadLine();
            String requiredString = "";

            if (str.Length > 4)
            {
                requiredString = String.Concat(str.Substring(0, 4).ToLower(), str.Substring(4, str.Length - 4).ToUpper());
            }
            else
            {
                requiredString = str.Substring(0, str.Length).ToLower();
            }
            Console.WriteLine(requiredString);
            Console.ReadLine();

        }
    }
}
