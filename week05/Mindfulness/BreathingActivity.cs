using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly."
        )
    {
    }

    public void Run()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountdown(4);

            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountdown(6);
        }

        End();
    }
}
