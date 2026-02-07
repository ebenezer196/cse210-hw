using System;

/*
EXCEEDING REQUIREMENTS:
- Added reusable spinner and countdown animations
- Used DateTime to manage duration
- Clean OOP structure with inheritance
*/

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }

            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }

            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }

            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }

            if (choice != "4")
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}
