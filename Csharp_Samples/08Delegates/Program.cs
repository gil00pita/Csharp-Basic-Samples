using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Delegates
{
    public delegate int MathFunction (int x);

    class Program
    {
        static void Main(string[] args)
        {
            MathFunction funcSQ = SquareArea;
            Console.WriteLine("The delegate is {0}", funcSQ(4));

            funcSQ = CubeArea;
            Console.WriteLine("The delegate is {0}", funcSQ(4));
            Console.ReadLine();
        }

        static int SquareArea(int val)
        {
            return val * val;
        }

        static int CubeArea(int val)
        {
            return val * val * val;
        }
    }
}
