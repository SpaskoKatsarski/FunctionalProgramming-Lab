using System;
using System.Linq;

namespace T04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();

            Func<decimal, decimal> addVAT = p => p * 1.20m;

            foreach (var price in prices)
            {
                Console.WriteLine($"{addVAT(price):f2}");
            }
        }
    }
}
