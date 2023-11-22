using System;

class Checklist : Goal
{
    public int _bonusValue;
    public int _compsNeeded;
    public int _timesCompleted;

    public Checklist(string name, int points, int bonusPoints, int completionsNeeded, int timesCompleted, bool complete, int pointsEarned) : base(name, points, complete, pointsEarned)
    {
        _bonusValue = bonusPoints;
        _bonus = _bonusValue;
        _compsNeeded = completionsNeeded;
        _timesCompleted = timesCompleted;
        _completionBox = $"[{timesCompleted}/{completionsNeeded}]";
    }
    public override void NewGoal()
    {
        Console.WriteLine("What is the name of the new goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("Write a short description for the goal. ");
        string description = Console.ReadLine();
        _nameDescription = $"{name} - {description}";
        Console.WriteLine("How many points will you get per completion of this goal? ");
        _pointValue = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times do you want to complete this goal?");
        _compsNeeded = int.Parse(Console.ReadLine());
        Console.WriteLine($"How many bonus points will you get for completing the goal {_compsNeeded} times? ");
        _bonusValue =  int.Parse(Console.ReadLine());
    }

    public override string GoalAsString()
    {
        return $"CHECKLIST|{_nameDescription}|{_pointValue}|{_isComplete}|{_bonusValue}|{_compsNeeded}|{_timesCompleted}|{_pointsEarned}";
    }

    public override void MarkComplete()
    {
        if (!_isComplete)
        {
                _timesCompleted++;
            if (_timesCompleted == _compsNeeded)
            {
                _isComplete = true;
                _completionBox = $"[{_timesCompleted}/{_compsNeeded}]";
                _pointsEarned += _pointValue;
                _pointsEarned += _bonusValue;
            }
            else
            {
                _completionBox = $"[{_timesCompleted}/{_compsNeeded}]";
                _pointsEarned += _pointValue;
            }
        }
    }

}