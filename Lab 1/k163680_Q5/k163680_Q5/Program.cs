using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k163680_Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            string string11 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
            string string12 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });

            string string21 = new string(new char[] { 'c', 'e', 'n', 't', 'e' , 'r' });
            string string22 = new string(new char[] { 'c', 'e', 'n', 't', 'r' , 'e' });

            if (CompareObjects(string11, string12))
                Console.WriteLine($"Strings {string11} and {string12} are equal..");
            else
                Console.WriteLine($"Strings {string11} and {string12} are not equal..");

            if (CompareObjects(string21, string22))
                Console.WriteLine($"Strings {string21} and {string22} are equal..");
            else
                Console.WriteLine($"Strings {string21} and {string22}  are not equal..");

            Console.ReadLine();

        }
        public static bool CompareObjects(object item1, object item2)
        {
            return item1.Equals(item2);
        }
    }
}
