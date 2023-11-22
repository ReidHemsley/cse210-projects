using System;

class Program
{
    static List<Goal> goals = new List<Goal>();
    public static int _totalPoints = 0;

    static void Main(string[] args)
    {
        while (true)
        {
             Console.WriteLine("\nChoose an option: \n1. Add Goal \n2. Mark Goal Complete \n3. Display Goals \n4. Save Goals \n5. Load Goals \n6. Exit");
            string option = Console.ReadLine();

            if (option == "1")
            {
                AddGoal();
            }
            else if (option == "2")
            {
                MarkGoalComplete();
            }
            else if (option == "3")
            {
                DisplayGoals();
            }
            if (option == "4")
            {
                Console.WriteLine("Enter filename to save goals:");
                string fileName = Console.ReadLine();
                SaveLoad.SaveGoals(goals, fileName);
            }
            else if (option == "5")
            {
                Console.WriteLine("Enter filename to load goals:");
                string fileName = Console.ReadLine();
                goals = SaveLoad.LoadGoals(fileName);
                UpdatePoints();
            }
            else if (option == "6")
            {
                break;
            }
        }
    }

    static void AddGoal()
    {
        Console.WriteLine("Select Goal Type: \n1. Simple \n2. Eternal \n3. Checklist");
        string type = Console.ReadLine();
        Goal newGoal = null;

        if (type == "1")
        {
            newGoal = new Simple("", 0, false, 0);
        }
        else if (type == "2")
        {
            newGoal = new Eternal("", 0, false, 0);
        }
        else if (type == "3")
        {
            newGoal = new Checklist("", 0, 0, 0, 0, false, 0);
        }
        else
        {
            Console.WriteLine("Invalid option.");
            return;
        }

        newGoal.NewGoal();
        goals.Add(newGoal);
    }

    static void MarkGoalComplete()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals available to mark as complete.");
            return;
        }

        Console.WriteLine("Select a goal to mark as complete:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]._nameDescription}");
        }

        Console.WriteLine("Enter the number of the goal:");
        int index;
        bool isValidInput = int.TryParse(Console.ReadLine(), out index);

        if (!isValidInput || index < 1 || index > goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = goals[index - 1];
        goal.MarkComplete();
        UpdatePoints();
        Console.WriteLine($"Goal '{goal._nameDescription}' marked as complete.");
    }


    static void UpdatePoints()
    {
        _totalPoints = 0;
        foreach (Goal goal in goals)
        {
            _totalPoints += goal._pointsEarned;
        }
    }

    static void DisplayGoals()
    {
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goal._completionBox} {goal._nameDescription} ~ Worth {goal._pointValue} Points");
        }
        Console.WriteLine($"Total Points: {_totalPoints}");
    }
   
}
