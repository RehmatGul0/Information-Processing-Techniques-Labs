using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace k163680_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(ConfigurationManager.AppSettings["EntityFrameworkPath"]);
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                if (type.IsClass)
                {
                    Console.WriteLine("Class Name:  {0} ..", type);
                    MethodInfo[] methods = type.GetMethods();
                    foreach (MethodInfo methodInfo in methods)
                        Console.WriteLine("Function name -> {0}",methodInfo.Name);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
