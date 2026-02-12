// Creativity:
// Added leveling system and motivational feedback

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int score = 0;

    static void Main()
    {
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\n=======================");
            Console.WriteLine($"Score: {score}");
            Console.WriteLine("=======================");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoals(); break;
                case 3: RecordEvent(); break;
                case 4: Save(); break;
                case 5: Load(); break;
            }
        }
    }

    // =========================

    static void CreateGoal()
    {
        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            goals.Add(new SimpleGoal(name, desc, points));
        }

        else if (type == 2)
        {
            goals.Add(new EternalGoal(name, desc, points));
        }

        else if (type == 3)
        {
            Console.Write("Target times: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    // =========================

    static void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()}");
        }
    }

    // =========================

    static void RecordEvent()
    {
        ListGoals();

        Console.Write("Which goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = goals[index].RecordEvent();

        score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    // =========================

    static void Save()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(score);

            foreach (Goal g in goals)
            {
                sw.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved!");
    }

    // =========================

    static void Load()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        score = int.Parse(lines[0]);
        goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts[0] == "Simple")
            {
                goals.Add(new SimpleGoal(
                    parts[1], parts[2],
                    int.Parse(parts[3])
                ));
            }

            else if (parts[0] == "Eternal")
            {
                goals.Add(new EternalGoal(
                    parts[1], parts[2],
                    int.Parse(parts[3])
                ));
            }

            else if (parts[0] == "Checklist")
            {
                goals.Add(new ChecklistGoal(
                    parts[1], parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                ));
            }
        }

        Console.WriteLine("Loaded!");
    }
}
