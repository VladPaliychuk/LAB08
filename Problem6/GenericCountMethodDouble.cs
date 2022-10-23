using System;

namespace Problem6
{
    internal class GenericCountMethodDouble
    {
        static void Main(string[] args)
        {
            var list = new Box<double>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(double.Parse(Console.ReadLine()));
            }
            list.Count(double.Parse(Console.ReadLine()));
        }
    }
}
