using System;

namespace Problem1
{
    internal class GenericBoxOfString
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();
                var data = new Box<string>(item);
                Console.WriteLine(data);
            }
        }
    }
}
