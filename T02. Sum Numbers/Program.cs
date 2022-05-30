using System;
using System.Linq;

namespace T02._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Func<int[], int> sumNumbers = n => n.Sum();
            Func<int[], int> countNumbers = n => n.Length;

            int count = countNumbers(numbers);


            Console.WriteLine(count + "\r\n" + sumNumbers(numbers));
        }
    }
}
