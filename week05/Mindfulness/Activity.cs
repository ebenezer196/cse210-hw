using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine();
        Console.WriteLine("Good job! You did well!");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i = (i + 1) % spinner.Length;
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
