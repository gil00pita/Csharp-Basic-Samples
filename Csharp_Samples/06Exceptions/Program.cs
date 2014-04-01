using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 23;
            int y = 0;
            int res;

            try
            {
                res = x / y;
                Console.WriteLine("The result is: {0}", res);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("Not dividable by zero!");
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("This code Finally runs.");
            }

            Console.ReadLine();
        }
    }
}
