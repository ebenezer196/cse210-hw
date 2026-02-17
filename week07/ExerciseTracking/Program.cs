using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Liste polymorphique
        List<Activity> activities = new List<Activity>();

        // Création des objets
        activities.Add(new Running("03 Nov 2022", 30, 4.8));
        activities.Add(new Cycling("03 Nov 2022", 45, 20.0));
        activities.Add(new Swimming("03 Nov 2022", 40, 50));

        // Affichage
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
