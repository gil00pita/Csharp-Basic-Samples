using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            char myChar = 'a';
            string myString = "  This is a string test with a \n newline" + @" (\n) and spaces in it.  ";

            //character tests
            Console.WriteLine("char.IsDigit: {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter: {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsUpper: {0}", char.IsUpper(myChar));
            Console.WriteLine("char.ToUpper: {0}", char.ToUpper(myChar));
            Console.WriteLine("char.ToLower: {0}", char.ToLower(myChar));
            Console.WriteLine("char.IsPunctuation: {0}", char.IsPunctuation(myChar));
            Console.WriteLine("char.IsWhiteSpace: {0}", char.IsWhiteSpace(myChar));
            Console.WriteLine();

            //string tests
            Console.WriteLine("string.LastIndexOf: {0}", myString.LastIndexOf("and"));
            Console.WriteLine("string.IndexOf: {0}", myString.IndexOf("a"));
            Console.WriteLine("string.Trim: {0}", myString.Trim());
            Console.WriteLine("string.ToUpper: {0}", myString.ToUpper());
            Console.WriteLine("string.ToLower: {0}", myString.ToLower());

            Console.ReadLine();
         
            /*
            Another examples:
                string a = "hello, world";                  // hello, world
                string b = @"hello, world";                 // hello, world
                string c = "hello \t world";                // hello     world
                string d = @"hello \t world";               // hello \t world
                string e = "Joe said \"Hello\" to me";      // Joe said "Hello" to me
                string f = @"Joe said ""Hello"" to me";     // Joe said "Hello" to me
                string g = "\\\\server\\share\\file.txt";   // \\server\share\file.txt
                string h = @"\\server\share\file.txt";      // \\server\share\file.txt
                string i = "one\r\ntwo\r\nthree";
                string j = @"one
                             two
                             three";
           */
        }
    }
}
