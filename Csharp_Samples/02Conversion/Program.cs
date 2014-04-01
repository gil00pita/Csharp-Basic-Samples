using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example
            int h = 10;
            short g = 5;
            float f = 20.0f;

            h = (int)f;
            h = g;
            g = (short)f;

            //Testing Double and Decimal

            double t20var = 0.4f;
            double varOne = 1.0f;

            Console.WriteLine("Result of Double {0}", varOne - t20var);

            decimal t120var = 0.4m;
            decimal realVar = 1.0m;

            Console.WriteLine("Result of Decimal {0}", realVar - t120var);

            Console.ReadLine();
        }
    }
}
