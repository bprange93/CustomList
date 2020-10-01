using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class MyList<T>
    {
        public int count;
        public int capacity;

        private T[] _items;


        public MyList()
        {
            count = 0;
            capacity = 4;

            _items = new T[capacity];
        }

        //public void Add(T item)
        //{
        //    _items[count] = item;
        //    count++;
        //}
    }
}
