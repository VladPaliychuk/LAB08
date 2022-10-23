using System;

namespace Problem2
{
    internal class GenericBoxOfInteger
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int item = int.Parse(Console.ReadLine());
                var data = new Box<int>(item);
                Console.WriteLine(data);
            }
        }
    }
}
