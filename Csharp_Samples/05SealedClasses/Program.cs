using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SealedClasses
{
    public abstract class RoundShape
    {
        public virtual  double Radius { get; set; }
        public abstract double Diameter { get; }
    }

    public class Circle : RoundShape
    {
        private double rad;

        public sealed override double Radius // sealed before override
        {
            get
            {
                return this.rad;
            }

            set
            {
                this.rad = value;
            }
        }

        public override sealed double Diameter // override before sealed = same thing
        {
            get
            {
                return this.rad * 2;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            RoundShape circ = new Circle();
            circ.Radius = 42.86;

            Console.WriteLine("Circle Characteristics");
            Console.WriteLine("Radius:   {0}", circ.Radius);
            Console.WriteLine("Diameter: {0}", circ.Diameter);

            Console.ReadLine();
        }
    }
}
