using System;

class Program
{
    static void Main(string[] args)
    {
        
        var scriptures = new[]
        {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
            ),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            )
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Length)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }
        }
    }
}

/*
EXCEEDING REQUIREMENTS:
- Implemented a library of scriptures instead of a single scripture.
- Randomly selects a scripture each time the program runs.
- Improved the word hiding logic to only hide words that are not already hidden.
*/
