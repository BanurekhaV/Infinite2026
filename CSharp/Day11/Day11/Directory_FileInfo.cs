using System;
using System.Collections.Generic;
using System.IO;

namespace Day11
{
    internal class Directory_FileInfo
    {
        static void Main()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Banu\2026\DotNet\TestDir");
            if (dirinfo.Exists)
            {
                Console.WriteLine("Directory with the given name already exists...");
            }
            else
            {
                dirinfo.Create();
                Console.WriteLine("Directory created ...");
            }
            Console.WriteLine("------------Iterating existing directory-----------");

            DirectoryInfo mydir = new DirectoryInfo(@"C:\Banu\2026\DotNet\CSharp");
            if (mydir.Exists)
            {
                DirectoryInfo[] directories = mydir.GetDirectories();

                foreach(object o in directories)
                {
                    Console.WriteLine(o.ToString());
                }
            }
            else
                Console.WriteLine("No directory exists...");

            //getting all the files in a given directory
            Console.WriteLine("--------File Info---------");

            FileInfo[] f = mydir.GetFiles();

            foreach (FileInfo fi in f)
            {
                Console.WriteLine("File Name : {0} Size {1} with Extension {2} ", fi.Name , fi.Length, fi.Extension);
            }
            Console.Read();
        }
    }
}
