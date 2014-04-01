using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAndAccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Water w1 = new Water("Luso", 2.00m);
            Water w2 = new Water("Serra da Estrela", 1.20m);

            w2.Description = "A puresa da Água...";

            Console.WriteLine("Water of Brand: {0}, costs: {1} €", w1.Brand, w1.Price);
            Console.WriteLine("Water of Brand: {0}, ( {1} ), costs: {2} €", w2.Brand, w2.Description, w2.Price);
            Console.ReadLine();
        }
    }
}
