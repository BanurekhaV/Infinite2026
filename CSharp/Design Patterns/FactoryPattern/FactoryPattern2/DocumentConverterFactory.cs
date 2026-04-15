using FactoryPattern2.Interfaces;
using FactoryPattern2.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2
{
   public class DocumentConverterFactory
    {
        public static IDocumentConverter CreateDocumentConverter(string format)
        {
            switch (format.ToLower())
            {
                case "docx":
                    return new DocxConverter();
                 

                default:
                    throw new ArgumentException("Format not Supported");
            }
        }
    }
}
