using System;

public abstract class Activity
{
    // Encapsulation: variables privées
    private string _date;
    private int _minutes;

    // Constructeur
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Getters protégés
    protected int GetMinutes()
    {
        return _minutes;
    }

    protected string GetDate()
    {
        return _date;
    }

    // Méthodes abstraites (polymorphisme)
    public abstract double GetDistance(); // km
    public abstract double GetSpeed();    // kph
    public abstract double GetPace();     // min per km

    // Méthode commune
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_minutes} min) - " +
               $"Distance: {GetDistance():0.00} km, " +
               $"Speed: {GetSpeed():0.00} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}
