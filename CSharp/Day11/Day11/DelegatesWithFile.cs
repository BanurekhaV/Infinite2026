using System;
using System.Collections.Generic;
using System.IO;

namespace Day11
{
    public delegate void Prints(string s);
    internal class DelegatesWithFile
    {
        static FileStream fs;
        static StreamWriter sw;

        public static void WritetoScreen(string s)
        {
            Console.WriteLine("The string is {0} ", s);
        }

        public static void WritetoFile(string s)
        {
            fs = new FileStream("Message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendString(Prints prints)
        {
            prints("This is a C# Class on Delegates and Files..");
        }

        static void Main()
        {
            Prints ps1 = new Prints(WritetoScreen);
            ps1 += WritetoFile;
            SendString(ps1);
            Console.Read();
        }
    }
}
