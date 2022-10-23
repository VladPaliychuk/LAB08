using System;
using System.Collections.Generic;

namespace Problem5
{
    internal class GenericCountMethodString
    {
        static void Main(string[] args)
        {
            var list = new Box<string>();

            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Count(Console.ReadLine());
        }
    }
}
