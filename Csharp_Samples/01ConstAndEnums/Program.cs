using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstAndEnums
{
    class Program
    {
        // enum is the same as constants but in a form of object
        enum waterTemp
        {
            FREEZE = 0,
            LOW = 15,
            NORMAL = 16,
            HOT = 35,
            BOILING = 100
        }

        static void Main(string[] args)
        {
            // This is constants, they are values that won't change during the program execution
            const int mercuryFreezePoint = -332;
            const int mercuryBoilingPoint = 10;

            int varTemp = -65;

            if (varTemp > mercuryFreezePoint && varTemp < mercuryBoilingPoint)
            {
                Console.WriteLine("Mercury is in liquid state");
            }
            else
            {
                Console.WriteLine("Mercury is not liquid state");
            }

            if (varTemp > (int)waterTemp.FREEZE && varTemp < (int)waterTemp.BOILING)
            {
                Console.WriteLine("The water is in liquid state");
            }
            else
            {
                Console.WriteLine("The Water is not a liquid state");
            }

            Console.ReadLine();
        }
    }
}
