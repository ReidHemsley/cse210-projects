using System;

class SaveLoad
{
    public static void SaveGoals(List<Goal> goals, string fileName)
    {
        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (Goal goal in goals)
            {
                file.WriteLine(goal.GoalAsString());
            }
        }
    }

    public static List<Goal> LoadGoals(string fileName)
    {
        List<Goal> loadedGoals = new List<Goal>();

        using (StreamReader file = new StreamReader(fileName))
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                string goalType = parts[0];
                Goal goal = null;

                if (goalType == "SIMPLE")
                {
                    goal = ParseSimpleGoal(parts);
                }
                else if (goalType == "ETERNAL")
                {
                    goal = ParseEternalGoal(parts);
                }
                else if (goalType == "CHECKLIST")
                {
                    goal = ParseChecklistGoal(parts);
                }

                if (goal != null)
                {
                    loadedGoals.Add(goal);
                }
            }
        }

        return loadedGoals;
    }

    private static Goal ParseSimpleGoal(string[] parts)
    {
        var simpleGoal = new Simple(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]), int.Parse(parts[4]));
        return simpleGoal;
    }

    private static Goal ParseEternalGoal(string[] parts)
    {
        var eternalGoal = new Eternal(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]), int.Parse(parts[4]));
        return eternalGoal;
    }
    private static Goal ParseChecklistGoal(string[] parts)
    {
        var checklistGoal = new Checklist(parts[1], int.Parse(parts[2]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[3]), int.Parse(parts[7]));
        return checklistGoal;
    }

}
