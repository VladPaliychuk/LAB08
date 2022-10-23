using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    internal class Box<T>
    {
        private T data;
        private List<T> list;

        public Box(T data)
        {
            this.data = data;
        }
        public Box()
        {
            this.list = new List<T>();
        }

        public void Add(T element)
        {
            this.list.Add(element);
        }
        public void Swap(int a, int b)
        {
            var k = this.list[a];
            this.list[a] = this.list[b];
            this.list[b] = k;
        }
        public override string ToString()
        {
            string[] r = new string[this.list.Count];
            for(int i = 0; i < this.list.Count; i++)
            {
                r[i] = $"{this.list[i].GetType().FullName}: {this.list[i].ToString()}";
            }
            return String.Join("\n", r);
        }
    }
}
