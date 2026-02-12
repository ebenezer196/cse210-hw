public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points,
                         int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _current = 0;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _current++;

            if (_current >= _target)
            {
                _isComplete = true;
                return _points + _bonus;
            }

            return _points;
        }

        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_name} ({_current}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_current}|{_target}|{_bonus}|{_isComplete}";
    }
}
