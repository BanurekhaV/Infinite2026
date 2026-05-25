using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Repository
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetByID(object Id);
        void Insert(T obj);
        void Update(T obj);
        void Delete(object Id);
        void Save();
    }
}
