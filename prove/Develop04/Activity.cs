using System;
using System.Globalization;
using System.Threading.Tasks.Dataflow;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected virtual void DoActivity()
    {}

    public void Start()
    {
        DisplayStartMessage();
        DoActivity();
        DisplayEndMessage();
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"{_name} - Description: {_description}");
        GetDuration();
        Console.WriteLine("Prepare to Start");
        DoSpinner(3);
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"Well done! You are finished with the {_name} activity!");
        Console.WriteLine($"The activity lasted {_duration} seconds.");
        DoSpinner(3);
        Console.WriteLine();
    }

    public int GetDuration()
    {
        Console.WriteLine("How long (in seconds) would you like to do this for?");
        return _duration = int.Parse(Console.ReadLine());
    }

    public void DoSpinner(int _duration)
    {
        List<string> spinnerStrings = new List<string>();
        spinnerStrings.Add("|");
        spinnerStrings.Add("/");
        spinnerStrings.Add("─");
        spinnerStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = spinnerStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");


            i++;

            if (i >= spinnerStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void DoCountDown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write($"\b \b\b\b");
        }
    }
}

