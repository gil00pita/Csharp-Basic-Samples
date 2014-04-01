using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionsAndMethods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Example 1
            Console.WriteLine("Example 1:\n");
            int var1;
            var1 = funct(14);
            Console.WriteLine("The solution is: {0}", var1);
            Console.WriteLine("End of Example 1\n------------------------------");

            //Example 2 (Named parameters)
            Console.WriteLine("Example 2:\n");
            ParamExample2(state: "Lisbon", zip: 3060, city: "Madrid");
            ParamExample2(city: "Porto", zip: 6822, state: "Algarve");
            ParamExample2(zip: 6554, city: "Faro", state: "New York");
            Console.WriteLine("End of Example 2\n------------------------------");

            //Example 3 (Optional parameters example)
            Console.WriteLine("Example 3:\n");
            ParamExample3(5);
            ParamExample3(1, 1.0028d);
            ParamExample3(1, 1.71828d, "a string");
            
            // Now 2 & 3
            ParamExample3(10, p3: "optional!");
            Console.WriteLine("End of Example 3\n------------------------------");

            //Example 4 (params)
            Console.WriteLine("Example 4:\n");
            int result;

            result = paramNumbers(4, 6, 8);
            Console.WriteLine("The result is {0}", result);

            result = paramNumbers(12, 20, 31, 5, 7, 9);
            Console.WriteLine("The result is {0}", result);
            Console.WriteLine("End of Example 4\n------------------------------");

            Console.ReadLine();
        }

        static int paramNumbers(params int[] value)
        {
            int totalValues = 0;

            foreach (int x in value)
            {
                totalValues += x;
            }

            return totalValues;
        }

        static int funct(int inputVar)
        {
            return (inputVar * 5) / 2;
        }
       
        static void ParamExample3(int p1, double p2 = 3.14159d, string p3 = "placeholder string")
        {
            Console.WriteLine("Function Arguments: \n\tp1 {0}, \n\tp2 {1}, \n\tp3 {2}", p1, p2, p3);
        }

        static void ParamExample2(string city, string state, int zip)
        {
            Console.WriteLine("Function Arguments: \n\tCity Name is {0}, \n\tState Name is {1}, \n\tZip Code is {2}",
                        city, state, zip);
        }
    }
}
