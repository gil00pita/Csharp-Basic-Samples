using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // for files and directories don't forget this!!

namespace Existing
{
    class Program
    {
        static void Main(string[] args)
        {
            bool fileStatus = false;
            string PathVar = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string FileName = PathVar + @"\filename.txt";

            fileStatus = File.Exists(FileName);

            if (fileStatus)
            {
                Console.WriteLine("File exists!");
            }
            else
            {
                Console.WriteLine("Missing File, creating it!");
                File.Create(FileName);
            }

            if (fileStatus)
            {
                Console.WriteLine("The file was created on {0}", File.GetCreationTime(FileName));
                Console.WriteLine("The file was last accessed on {0}", File.GetLastAccessTime(FileName));

                Console.WriteLine("Renaming or Moving file...");
                File.Move(FileName, PathVar + @"\NameOfTheFile.txt");

                //Other Path operations methods
                Console.WriteLine("The Directory Name is {0}", Path.GetDirectoryName(PathVar));
                Console.WriteLine("The File Name With Extension is {0}", Path.GetFileName(PathVar));
                Console.WriteLine("The File Name Without Extension is {0}", Path.GetFileNameWithoutExtension(PathVar));
                Console.WriteLine("The Random file name for this path is {0}", Path.GetRandomFileName());
            }

            Console.ReadLine();
        }
    }
}
