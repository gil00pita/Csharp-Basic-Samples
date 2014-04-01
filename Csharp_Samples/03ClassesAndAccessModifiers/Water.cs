using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassesAndAccessModifiers
{
    class Water
    {
        public string Brand;
        public decimal Price;
        public string Description;

        private decimal discountValue;

        public Water(string waterName, decimal price_value) {
            Brand = waterName;
            Price = price_value;
            discountValue = 0.0m;
        }
    }
}
