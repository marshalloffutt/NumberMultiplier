using System;

namespace NumberMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some numbers, and separate them with commas. No spaces!");

            // 1. Split the input string into a string array
            // 2. Loop over the array of strings, and convert to numbers
            // 3. Mutiply each value, store results in total

            string input = Console.ReadLine();
            string[] inputArray = input.Split(',');
            int total = 1;

            foreach (string val in inputArray)
            {
                int number = int.Parse(val);
                total *= number;
            }

            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
