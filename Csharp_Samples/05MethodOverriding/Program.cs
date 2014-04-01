using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverriding
{
    class baseClass
    {
        public virtual void SomethingToDo() 
        {
            Console.WriteLine("This is the baseClass");
        }
    }

    class subClass : baseClass
    {
        public override void SomethingToDo()
        {
            base.SomethingToDo();
            Console.WriteLine("This is the subClass");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            baseClass obj = new subClass();
            obj.SomethingToDo();
            Console.ReadLine();
        }
    }
}
