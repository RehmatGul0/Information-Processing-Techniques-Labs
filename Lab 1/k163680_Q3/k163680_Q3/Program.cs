using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k163680_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //For demo purpose only calculator class required as mentioned in question.
            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.add(1, 2, 3, 4));
            Console.WriteLine(calculator.add(1, 2, 3, 4, 5, 6));
            Console.ReadLine();
        }
    }
}
