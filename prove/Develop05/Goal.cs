using System;
using System.ComponentModel;
using System.Runtime;

abstract class Goal
{
    public string _goalType;
    public string _nameDescription;
    public int _pointValue;
    public bool _isComplete;
    public string _completionBox;
    public int _bonus;
    public int _pointsEarned;

    public Goal(string name, int points, bool isComplete, int pointsEarned)
    {
        _nameDescription = name;
        _pointValue = points;
        _isComplete = isComplete;
        _pointsEarned = pointsEarned;
        _completionBox = "[ ]";
    }

    List<Goal> goals = new List<Goal>();

    public abstract void NewGoal();

    public abstract void MarkComplete();

    public abstract string GoalAsString();

    public void AddGoalToList(Goal goal)
    {
        goals.Add(goal);
    }

}