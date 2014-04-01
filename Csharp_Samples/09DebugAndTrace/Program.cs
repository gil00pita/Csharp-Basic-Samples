using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics; // need this to use the Debug class

namespace DebugingAndTracing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using file methods example
            string _Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                Path.DirectorySeparatorChar + "namefile.txt";
            if (!File.Exists(_Path))
            {
                CreateFile(_Path);
            }

            WriteFileData(_Path, "Hello, this is a txt file!" + Environment.NewLine);
            Console.WriteLine("######################################");
            Console.WriteLine("The text on the file is:");

            ReadAndListFileContents(_Path);
            Console.ReadLine();
        }

        static void CreateFile(string file_Path)
        {
            string txtcontent = "Hello, this is a txt file!" + Environment.NewLine;
            Console.WriteLine("Creating the txt file...");
            File.WriteAllText(file_Path, txtcontent);
            
            Debug.WriteLine("Created the file! And it content is: {0}", (object)txtcontent);
        }

        static void WriteFileData(string file_Path, string content)
        {
            Debug.Assert(content.Length > 0);

            Debug.Indent();
            Debug.WriteLine("Writing data on the file");
            Debug.Unindent();

            string addText = content + Environment.NewLine;
            Console.WriteLine("Adding text into the file...");
            File.AppendAllText(file_Path, addText);
            Console.WriteLine();

            Debug.Indent();
            Debug.WriteLine("The data was written on the file");
            Debug.Unindent();
        }

        static void ReadAndListFileContents(string file_Path)
        {
            string[] FileContent = File.ReadAllLines(file_Path);

            Debug.WriteLineIf(FileContent.Length < 1, "The file has no text");

            foreach (string str in FileContent)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
    }
}
