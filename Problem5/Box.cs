using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Box<T> where T : IComparable<T>
    {
        private T data;
        private List<T> list;
        public Box()
        {
            this.list = new List<T>();
        }
        public void Add(T element)
        {
            this.list.Add(element);
        }
        public void Count(T data)
        {
            int n = 0;

            foreach(var element in this.list)
            {
                if (data.CompareTo(element) < 0)
                {
                    n++;
                }
            }

            Console.WriteLine(n);
        }
    }
}
