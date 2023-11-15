using System;

class Eternal : Goal
{
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
        return $"{_goalType},{_nameDescription},{_pointValue}{_isComplete},{_bonusValue},{_compsNeeded},{_timesCompleted}";
    }

}