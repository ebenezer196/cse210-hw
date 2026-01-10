
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int userNumber;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Input loop
        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            userNumber = int.Parse(input);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        // Core requirements
        int sum = numbers.Sum();
        double average = (numbers.Count > 0) ? numbers.Average() : 0;
        int max = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch challenge
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
        if (smallestPositive > 0)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There is no positive number in the list.");
        }

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
