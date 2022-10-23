using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class List<T> where T : IComparable<T>
    {
        private T[] array = Array.Empty<T>(); //для економії пам'яті

        public void Add(T value)
        {
            var newArray = new T[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[array.Length] = value;
            array = newArray;
        }
        public T Remove(int index)
        {
            var element = array[index];
            for(int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            var newArray = new T[array.Length - 1];
            Array.Copy(array, newArray, array.Length - 1);
            array = newArray;

            return element;
        }
        public bool Contains(T element)
        {
            foreach (var item in array)
            {
                if(element.CompareTo(item) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        public void Swap(int index1, int index2)
        {
            var element = array[index1];
            array[index1] = array[index2];
            array[index2] = element;
        }
        public int CountGreaterThan(T element)
        {
            int n = 0;

            foreach(var item in array)
            {
                if (element.CompareTo(item) < 0)
                {
                    n++;
                }
            }

            return n;
        }
        public T Max()
        {
            return array.Max();
        }
        public T Min()
        {
            return array.Min();
        }
        public void Sort()
        {
            Array.Sort(array);
        }
        public override string ToString()
        {
            return String.Join(" ", array);
        }
    }
}
