using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarbageCollectorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GC.Collect();//Force Garbage Collector to clean and save memory (the dotnet do this automaticly, no need to use thiss)
            Console.WriteLine("The allocated memory used by this application is: {0}", GC.GetTotalMemory(false));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
