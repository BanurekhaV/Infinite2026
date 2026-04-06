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
           //ReadBinary();
           StreamReadWrite.WriteStreams();
           StreamReadWrite.ReadStreams();
            Console.Read();
        }
    }

    class StreamReadWrite
    {
        //stream reader and writer
       public static FileStream fs;
       public static void ReadStreams()
        {
            fs = new FileStream("OurFile.txt", FileMode.Open, FileAccess.Read);

            //we can position the file pointer
            StreamReader reader = new StreamReader(fs);

            reader.BaseStream.Seek(9, SeekOrigin.Begin);

            //read till the end of file
            string str = reader.ReadLine();
            while(str !=null)
            {
                Console.WriteLine("{0}", str);
                str = reader.ReadLine();
            }

            reader.Close();
            fs.Close();
        }

        public static void WriteStreams()
        {
            //let us create a filestream object
            fs = new FileStream("OurFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            //prompt the user for details
            Console.WriteLine("Enter a String :");
            string str = Console.ReadLine();

            //now write the string onto the file
            sw.Write(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        
    }
}
