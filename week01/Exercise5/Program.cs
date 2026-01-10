using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcome();

            string userName = PromptUserName();
            int favoriteNumber = PromptUserNumber();
            int squaredNumber = SquareNumber(favoriteNumber);

            DisplayResult(userName, squaredNumber);
        }

        // Function to display the welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Function to prompt for and return the user's name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }

        // Function to prompt for and return the user's favorite number
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input); // Assumes user inputs a valid integer
            return number;
        }

        // Function to square the number
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Function to display the final result
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}