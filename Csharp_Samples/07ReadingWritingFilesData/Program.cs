using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadingWritingFilesData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string _Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                Path.DirectorySeparatorChar + "filename.txt";

            //if the filename.txt doesn't exist
            if (!File.Exists(_Path))
            {
                string contentFile = "Hello, this is a txt file!" + Environment.NewLine;
                Console.WriteLine("Creating file...");
                File.WriteAllText(_Path, contentFile);
            }

            //add text to the content method (AppendAllText)
            string TextToAdd = "Text added at the end of the file" + Environment.NewLine;
            Console.WriteLine("Adding text into the file...");
            File.AppendAllText(_Path, TextToAdd);
            Console.WriteLine();

            //Read the file
            Console.WriteLine("######################################");
            Console.WriteLine("The text on the file is:");
            

            //Read the contents of the file using ReadAllText
            string txtContent = File.ReadAllText(_Path);
            Console.Write(txtContent);
            Console.WriteLine();

            //Read the file contents with ReadAllLines method

            string[] txtcontent2 = File.ReadAllLines(_Path);
            foreach (string tx in txtcontent2)
            {
                Console.WriteLine(tx);
            }
            Console.WriteLine();
            

            Console.ReadLine();
        }
    }
}
