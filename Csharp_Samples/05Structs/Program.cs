using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingStructs
{
    public struct Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y) 
        {
            _x = x;
            _y = y;
        }

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }

        public int y
        {
            get { return _x; }
            set { _x = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(100, 100);
            Point p2 = new Point();
            p2.x = 50;
            p2.y = 75;
            Console.WriteLine("Points Characteristics:");
            Console.WriteLine("Point p1:  x: {0}, y: {1}", p1.x, p1.y);
            Console.WriteLine("Point p2:  x: {0}, y: {1}", p2.x, p2.y);
            Console.ReadLine();
        }
    }
}
