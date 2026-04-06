using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    internal class BinaryReadWrite
    {

        public static void WriteBinary()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"C:\Banu\2026\DotNet\mybinfile.bin", FileMode.Create)))
            {
                //writing error logs
                writer.Write("0x83456A0");
                writer.Write("Windows Explorer ran into a problem and stopped..");
                writer.Write(true);
            }
        }

        public static void ReadBinary()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("C:\\Banu\\2026\\DotNet\\mybinfile.bin", FileMode.Open)))
            {
                Console.WriteLine("Error code No : " + reader.ReadString());
                Console.WriteLine("Message " + reader.ReadString());
                Console.WriteLine("Restart Windows ? :" + reader.ReadBoolean());
            }
        }

        static void Main()
        {
           // WriteBinary();
           ReadBinary();
            Console.Read();
        }
    }
}
