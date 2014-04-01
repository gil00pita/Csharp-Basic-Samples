using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int theNumber = 2;

            switch (theNumber)
            {
                case 1:
                    Console.WriteLine("The value is 1");
                    break;
                case 2:
                    Console.WriteLine("The value is 2");
                    break;
                case 3:
                    Console.WriteLine("The value is 3");
                    break;
                default:
                    Console.WriteLine("The value is not 1, 2 or 3");
                    break;
            }
        }
    }
}
