using System;

namespace T03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> checkIfUpperCase = w => char.IsUpper(w[0]);

            foreach (var word in words)
            {
                if (checkIfUpperCase(word))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
