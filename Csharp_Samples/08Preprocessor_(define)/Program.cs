#define DEBUGCODE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefineExample
{
    class Program
    {
        #region Example of main function Region
        static void Main(string[] args)
        {
#if DEBUGCODE
            Console.WriteLine("Running in debug mode");
#else
            Console.WriteLine("Running in non-debug mode");
#endif
            Console.ReadLine();
        }
        #endregion
    }
}
