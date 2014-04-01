using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO; // for files and directories don't forget this!!

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            string PathVar = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Check if a directory exists
            bool dirCheck = Directory.Exists(PathVar);
            if (dirCheck)
                Console.WriteLine("The Folder My Documents exists.");
            else
                Console.WriteLine("The Folder My Documents does not exist.");
            Console.WriteLine();

            // Write the names of the files of the directory
            string[] fileNames = Directory.GetFiles(PathVar);
            foreach (string fn in fileNames)
            {
                Console.WriteLine("File: " + fn);
            }
            Console.WriteLine();

            // Check information about the disks drives
            Console.WriteLine("About the Drive:");
            foreach (DriveInfo di in DriveInfo.GetDrives())
            {
                if (di.DriveType == DriveType.Fixed)
                {
                    Console.WriteLine("Name: {0}", di.Name);
                    Console.WriteLine("Drive Type: {0}", di.DriveType);
                    Console.WriteLine("Free Space: {0}", di.TotalFreeSpace);
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
