using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k163680_Q3
{
    public class Calculator
    {
        public float add(float num1, float num2)
        {
            return num1 + num2;
        }

        public float add(float num1, params float[] parameters)
        {
            float sum = num1;
            foreach(float param in parameters)
                sum += param;
            return sum;
        }
        public float substract(float num1, float num2)
        {
            return num1 - num2;

        }
        public float multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public float divide(float num1, float num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                return float.MaxValue; 
        }

    }
}
