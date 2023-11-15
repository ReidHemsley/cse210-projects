using System;

class Checklist : Goal
{
    public int _bonusValue;
    public int _compsNeeded;
    public int _timesCompleted;

    public Checklist(string name, int points, int completionsNeeded, int bonusPoints) : base(name, points)
    {
        _bonusValue = bonusPoints;
        _compsNeeded = completionsNeeded;
        _timesCompleted = 0;
    }
    public override void NewGoal()
    {
        _goalType = "CHECKLIST";
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
        return $"{_goalType},{_nameDescription},{_pointValue}{_isComplete},{_bonusValue},{_compsNeeded},{_timesCompleted}";
    }

    public override void MarkComplete()
    {
        
    }
}