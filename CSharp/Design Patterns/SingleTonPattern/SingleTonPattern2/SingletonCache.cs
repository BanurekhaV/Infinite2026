using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPattern2
{
    public sealed class SingletonCache : IMyCache
    {
        ConcurrentDictionary<object,object> _cache = new ConcurrentDictionary<object,object>();

        private static readonly SingletonCache Instance = new SingletonCache();

        private SingletonCache()
        {
            Console.WriteLine("Singleton instance created...");
        }

        public static SingletonCache GetInstance()
        {
            return Instance;
        }
        public object Get(object key)
        {
            if (_cache.ContainsKey(key))
            {
                return _cache[key];
            }
            return null;
        }

        public bool Add(object key, object value)
        {
            return _cache.TryAdd(key, value);
        }

        public bool AddorUpdate(object key, object value)
        {
            if(_cache.ContainsKey(key))
            {
                _cache.TryRemove(key,out object removedkey);
            }
            return _cache.TryAdd(key,value);
        }

        public bool Remove(object key)
        {
            return _cache.TryRemove(key, out object value);
        }

        public void Clear()
        {
            _cache.Clear();
        }
    }
}
