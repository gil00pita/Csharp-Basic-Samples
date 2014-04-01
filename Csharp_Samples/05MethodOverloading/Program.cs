using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverloading
{
    class Water
    {
        public int ProtuctionDate;
        public string Name;
        public decimal price;

        public Water(string s)
        {
            Name = s;
        }
        public Water(string s, int y)
        {
            Name = s;
            ProtuctionDate = y;
        }
        public Water(string s, decimal p, int y)
        {
            Name = s;
            price = p;
            ProtuctionDate = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Water w1 = new Water("Luso");
            Water w2 = new Water("Serra da Estrela", 2014);
            Water w3 = new Water("Vitalis", 1.05m, 2012);

            Console.WriteLine("Name: {0}", w1.Name);
            Console.WriteLine("Production Date: {0}, Name: {1}", w2.ProtuctionDate, w2.Name);
            Console.WriteLine("Production Date: {0}, Name: {1}, Price: ", w3.ProtuctionDate, w3.Name, w3.price);

            Console.ReadLine();
        }
    }
}
