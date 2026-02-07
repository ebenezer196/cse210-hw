using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your heroes?"
    };

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you list positive things in your life."
        )
    {
    }

    public void Run()
    {
        Start();

        Random random = new Random();

        Console.WriteLine();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing. Press Enter after each item.");

        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items!");

        End();
    }
}
