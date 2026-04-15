using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern2
{
    public interface IMyCache
    {
        bool Add(object key, object value);
        bool Remove(object key);
        bool AddorUpdate(object key, object value);
        object Get(object key);
        void Clear();
    }
}
