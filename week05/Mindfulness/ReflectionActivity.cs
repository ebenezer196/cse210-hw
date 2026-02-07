using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you use this in the future?"
    };

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times of strength and resilience."
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
        Console.WriteLine("Reflect on this...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];

            Console.WriteLine();
            Console.WriteLine(question);

            ShowSpinner(5);
        }

        End();
    }
}
