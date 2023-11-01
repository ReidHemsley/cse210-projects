using System;
using System.Globalization;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    protected string DisplayStartMessage(string startMessage)
    {
        return startMessage;
    }

    protected string DisplayEndMessage(string endMessage)
    {
        return endMessage;
    }

    public void GetDuration(string duration)
    {
        _duration = int.Parse(duration);
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

