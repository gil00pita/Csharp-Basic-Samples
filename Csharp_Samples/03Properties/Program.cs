using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningProperties
{
    class Water
    {
        private string Brand;
        private int productionDate;
        private string Product;
        private decimal PriceOfSale;
        private const decimal retailPrice = 1.35m;

        public decimal Price
        {
            get
            {
                return PriceOfSale * retailPrice;
            }
            set
            {
                PriceOfSale = value;
            }
        }

        public string ProductDescription
        {
            get { return productionDate.ToString() + " " + Brand + ", " + Product; }
        }

        public Water(int d, string pName, string pApp, decimal sp) 
        {
            Brand = pName;
            productionDate = d;
            Product = pApp;
            PriceOfSale = sp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Create the Wine objects
            Water w1 = new Water(2014, "Luso", "Morango", 1.50m);
            Water w2 = new Water(2013, "Luso", "Limão", 1.70m);

            //Get out values
            Console.WriteLine("Water 1: {0}, {1}", w1.ProductDescription, w1.Price);
            Console.WriteLine("Water 2: {0}, {1}", w2.ProductDescription, w2.Price);
            Console.WriteLine();

            //Set price of one
            w2.Price = 1.25m;

            //Get description
            Console.WriteLine("Water 2: {0}, {1}", w2.ProductDescription, w2.Price);

            Console.ReadLine();
        }
    }
}
