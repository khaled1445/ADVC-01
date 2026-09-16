using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ADVC_01
{
    internal class SafeList<T>
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                return default(T);
            }
            return items[index];
        }
    }
}
