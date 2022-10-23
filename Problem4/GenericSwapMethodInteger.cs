using System;

namespace Problem4
{
    internal class GenericSwapMethodInteger
    {
        static void Main(string[] args)
        {
            var list = new Box<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            string[] input = Console.ReadLine().Split(' ');
            list.Swap(int.Parse(input[0]), int.Parse(input[1]));

            Console.WriteLine(list);
        }
    }
}
