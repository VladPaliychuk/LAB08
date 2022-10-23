using System;

namespace Problem7
{
    internal class CustomList
    {
        static void Main(string[] args)
        {
            var list=new List<string>();

            string input = Console.ReadLine();

            while (!input.Equals("END"))
            {
                var inputs = input.Split(' ');
                switch (inputs[0])
                {
                    case "Add":
                        list.Add(inputs[1]);
                        break;
                    case "Remove":
                        list.Remove(int.Parse(inputs[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(list.Contains(inputs[1]));
                        break;
                    case "Swap":
                        list.Swap(int.Parse(inputs[1]), int.Parse(inputs[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(inputs[1]));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Print":
                        Console.WriteLine(list);
                        break;
                    case "Sort":
                        list.Sort();
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
