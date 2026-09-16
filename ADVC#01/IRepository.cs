using System;
using System.Collections.Generic;
using System.Text;

namespace ADVC_01
{
    internal interface IRepository<T>
    {
        void Add(T item);
        T Get(int id);
        T Update(int id, T item);
        void Delete(int id);

    }
}
