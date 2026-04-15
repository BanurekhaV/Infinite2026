using FactoryPattern2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2.Products
{
    public class PDFConverter : IDocumentConverter
    {
        public  string Convert(string content)
        {
            Console.WriteLine("Converting content to PDF ...");
            return content + "[Converted to pdf]";
        }
        public string TargetExtension => ".pdf";
    }
}
