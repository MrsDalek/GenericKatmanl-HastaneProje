using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public interface IRepository<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();
        T GetById(int itemid);
    }
}
