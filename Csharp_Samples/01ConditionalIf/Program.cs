using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConditionalIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int onevar = 20;

            if (onevar == 20) 
            {
                Console.WriteLine("onevar = 20");
            }
            else if (onevar == 21)
            {
                Console.WriteLine("onevar = 21");
            }
            else
            {
                Console.WriteLine("onevar = !20 and !21");
            }

            Console.ReadLine();
        }
    }
}
