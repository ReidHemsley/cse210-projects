using System;

class Listing : Activity
{
    private List<string> _prompts = new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List<string> _responses = new List<string>();
    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {}

    protected override void DoActivity()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("You have 15 seconds to think about possible responses.");
        DoCountDown(15);
        Console.WriteLine("Start listing responses... (press ENTER after each)");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string _response = Console.ReadLine();
            _responses.Add(_response);
        }
        Console.WriteLine($"You listed {_responses.Count} items.");
    }
}