using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        HastaneDBEntities hdb = new HastaneDBEntities();
        public void Delete(T item)
        {
            hdb.Set<T>().Attach(item);
            hdb.Entry(item).State = EntityState.Modified;
            hdb.SaveChanges();
        }

        public List<T> GetAll()
        {
            return hdb.Set<T>().ToList();
        }

        public T GetById(int itemid)
        {
            return hdb.Set<T>().Find(itemid);
        }

        public void Insert(T item)
        {
            hdb.Set<T>().Add(item);
            hdb.SaveChanges();
        }

        public void Update(T item)
        {
            hdb.Set<T>().Attach(item);
            hdb.Entry(item).State = EntityState.Modified;
            hdb.SaveChanges();
        }
    }
}
