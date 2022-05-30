using System;
using System.Linq;

namespace T01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Predicate<int> func = x => x % 2 == 0;

            Console.WriteLine(string.Join(", ", nums.Where(x => func(x)).OrderBy(x => x)));
        }
    }
}
