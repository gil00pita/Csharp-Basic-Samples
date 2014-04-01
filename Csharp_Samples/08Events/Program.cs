using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Events
{
    public delegate void _EventHandler(string aNewValue);

    class EventExample
    {
        private string aValue;
        public event _EventHandler valueHasChanged;

        public string Val
        {
            set
            {
                this.aValue = value;
                this.valueHasChanged(aValue);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EventExample myEvent = new EventExample();

            myEvent.valueHasChanged += new _EventHandler(inCase_valueChanged);

            string str_var;
            do
            {
                str_var = Console.ReadLine();
                if (!str_var.Equals("exit"))
                    myEvent.Val = str_var;

            } while (!str_var.Equals("exit"));
        }

        static void inCase_valueChanged(string newValue)
        {
            Console.WriteLine("Now the value is {0}", newValue);
        }
    }
}
