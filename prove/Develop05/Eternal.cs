using System;
using System.Text;

class Eternal : Goal
{

    public Eternal(string name, int points, bool complete, int pointsEarned) : base(name, points, complete, pointsEarned)
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
        return $"ETERNAL|{_nameDescription}|{_pointValue}|false|{_pointsEarned}";
    }

    public override void MarkComplete()
    {
        _completionBox = "[ ]";
        _pointsEarned += _pointValue;
    }

}