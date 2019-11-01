using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace k163680_Q4
{
    class RandomInfo
    {
        static Random random = new Random();

        public static String getName()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 7; i++)
                builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))));
            return builder.ToString();
        }
        public static DateTime GetDateOfBirth()
        {
            return new DateTime(random.Next(1990, 2000), random.Next(1, 12), random.Next(1,29));
        }

        public static int getSemester()
        {
            return random.Next(1, 9);
        }
        public static double getGPA()
        {
            return random.Next(1, 4) + (random.Next(0, 99) / 100.0);
        }


    }
}
