public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name}";
    }

    public override string GetStringRepresentation()
    {
        return $"Simple|{_name}|{_description}|{_points}|{_isComplete}";
    }
}
