using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVC_CodeFirst.Models;

namespace MVC_CodeFirst.Repository
{
    public class ConcreteRepo<T> : IRepository<T> where T : class
    {
        ProductSalesContext db;
        DbSet<T> dbset;

        public ConcreteRepo()
        {
            db = new ProductSalesContext();
            dbset = db.Set<T>();
        }

        public void Delete(object id)
        {
            T getModel = dbset.Find(id);
            dbset.Remove(getModel);
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public T GetByID(object id)
        {
            return dbset.Find(id);
        }

        public void Insert(T obj)
        {
            dbset.Add(obj);
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}