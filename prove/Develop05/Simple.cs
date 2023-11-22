using System;
using System.Security.Cryptography.X509Certificates;

class Simple : Goal
{
    public Simple(string name, int points, bool complete, int pointsEarned) : base(name, points, complete, pointsEarned)
    {}
    public override void NewGoal()
    {
        Console.WriteLine("What is the name of the new goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("Write a short description for the goal. ");
        string description = Console.ReadLine();
        _nameDescription = $"{name} - {description}";
        Console.WriteLine("How many points will this goal be worth? ");
        _pointValue = int.Parse(Console.ReadLine());
    }

    public override string GoalAsString()
    {
        return $"SIMPLE|{_nameDescription}|{_pointValue}|{_isComplete}|{_pointsEarned}";
    }
    
        public override void MarkComplete()
    {
        _isComplete = true;
        _completionBox = "[X]";
        _pointsEarned += _pointValue;
    }

}
