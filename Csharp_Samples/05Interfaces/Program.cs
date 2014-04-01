using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*An interface contains only the signatures of methods, properties, events or indexers.
 * A class or struct that implements the interface must implement the members of the 
 * interface that are specified in the interface definition. 
 * In the following example, class ImplementationClass must implement a method named 
 * SampleMethod that has no parameters and returns void.
 */
namespace UsingInterfaces
{
    interface IPoint
    {
        // Property signatures: 
        int x
        {
            get;
            set;
        }

        int y
        {
            get;
            set;
        }
    }

    class Point : IPoint
    {
        // Fields: 
        private int _x;
        private int _y;

        // Constructor: 
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        // Property implementation: 
        public int x
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }

    class MainClass
    {
        static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.x, p.y);
        }

        static void Main()
        {
            Point p = new Point(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);
            Console.ReadLine();
        }
    }
    // Output: My Point: x=2, y=3
}
