using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClasses
{
    public abstract class Talk
    {
        //An abstract class cannot be instantiated as an object and is only provided for the purpose of deriving subclasses.
        public abstract void speak(); 
    }

    public class SayHello : Talk //Deriving from an Abstract Class
    {
        public override void speak()//Override the myMethod function 
        {
            Console.WriteLine("Hello!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SayHello hello = new SayHello();

            hello.speak();
            Console.ReadLine();
        }
    }
}
