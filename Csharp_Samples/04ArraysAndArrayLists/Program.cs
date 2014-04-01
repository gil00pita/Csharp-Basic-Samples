using System;
using System.Collections; // don't forget this!
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList's, don't need to initialize
            ArrayList ArrayLst = new ArrayList();
            ArrayLst.Add("First");
            ArrayLst.Add(2);
            ArrayLst.Add("Third");
            ArrayLst.Add(4);
            ArrayLst.Insert(0, 0.143f);

            foreach (object ob in ArrayLst)
            {
                if (ob is int)
                    Console.WriteLine("Int");
                else if (ob is string)
                    Console.WriteLine("String");
                else if (ob is float)
                    Console.WriteLine("Float");
            }

            //Array's
            int[] myArray = { 2, 11, 75, 3, 5, 8, 231, 1, 187, 700 };
            Console.WriteLine("myArray[4] = {0}", myArray[4]);

            string[] myArrayOfStrings = { "Gil", "Maria", "Fernado", "Luís" };
            for (int a = 0; a < 4; a++)
            {
                Console.WriteLine("{0}", myArrayOfStrings[a]);
            }

            int[] otherTypes = myArray;
            otherTypes[2] = 0;
            Console.WriteLine("myArray[2] = {0}", myArray[2]);

            Array.Sort(myArray);
            Console.WriteLine("myArray[3] = {0}", myArray[3]);

            Console.ReadLine();
        
        }
    }
}
