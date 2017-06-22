using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IBaseOperations<T>
    {
        bool Delete(int id);

        T Edit(int id);

        List<T> GetAll();

        T GetById(int id);

        void Insert(T item);
    }
}
