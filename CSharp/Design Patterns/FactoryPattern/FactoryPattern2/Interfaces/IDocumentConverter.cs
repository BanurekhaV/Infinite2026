using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern2.Interfaces
{
    public interface IDocumentConverter
    {
        string Convert(string content);
        string TargetExtension { get; }
    }
}
