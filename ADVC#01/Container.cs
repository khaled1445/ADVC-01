using System;
using System.Collections.Generic;
using System.Text;

namespace ADVC_01
{
    public class Container<T>
    {
        private T item;

        public void AddValue(T value)
        {
            item = value;
        }

        public T GetValue()
        {
            return item;
        }   
    }
}
