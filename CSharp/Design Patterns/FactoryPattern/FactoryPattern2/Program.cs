using FactoryPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the content :");
            string content = Console.ReadLine();
            Console.WriteLine("Enter the format like PDF, DOCX, TXT");
            string format = Console.ReadLine();
            try
            {
                IDocumentConverter converter = DocumentConverterFactory.CreateDocumentConverter(format);
                string convertedcontent = converter.Convert(content);
                Console.WriteLine($"Converted content {converter.TargetExtension} : {convertedcontent}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
