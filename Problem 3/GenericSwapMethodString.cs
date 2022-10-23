using System;
using System.Collections.Generic;
using System.Collections;

namespace Problem_3
{
    internal class GenericSwapMethodString
    {
        public static void Main()
        {
            var list = new Box<string>();

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            string[] input = Console.ReadLine().Split(' ');
            list.Swap(int.Parse(input[0]), int.Parse(input[1]));

            Console.WriteLine(list);
        }
    }
}
