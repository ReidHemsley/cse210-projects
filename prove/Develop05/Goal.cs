using System;
using System.ComponentModel;
using System.Runtime;

abstract class Goal
{
    public string _goalType;
    public string _nameDescription;
    public int _pointValue;
    public bool _isComplete;
    private int _totalPoints = 0;

    public Goal(string name, int points)
    {
        _nameDescription = name;
        _pointValue = points;
    }

    List<Goal> goals = new List<Goal>();

    public abstract void NewGoal();

    public abstract void MarkComplete();

    public abstract string GoalAsString();
    public void AddGoaltoList()
    {
        
    }
}