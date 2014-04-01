using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 2;

            Console.WriteLine("While loop:");
           
            //while loop
            while (myVar < 10) {
                Console.WriteLine("myVar is {0}", myVar);
                myVar += 3; //add a way to stop the loop
            }
            Console.WriteLine();

            //do-while loop
            Console.WriteLine("Do-while loop:");
            do
            {
                Console.WriteLine("myVar is {0}", myVar);
                myVar += 3;
            } while (myVar < 10);
            Console.WriteLine();

            //for loop
            Console.WriteLine("For loop:");
            for (int i = 0; i < myVar; i += 2)
            {
                Console.WriteLine("i is {0}", i);
            }
            Console.WriteLine();

            // using the "continue" and "break"
            Console.WriteLine(@"Using ""break"" and ""continue"" :");
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue; // skip the rest of this loop and go to until finishes the i var

                if (i == 9)
                    break; //stop the loop

                Console.WriteLine("i is {0}", i);
            }
            Console.ReadLine();
        }
    }
}
