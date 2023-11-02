using System;

class Breathing : Activity
{
    public Breathing() : base("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    
    protected override void DoActivity()
    {
        Console.WriteLine("Follow the instuctions. We will begin in ");
        DoCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breath in...");
            DoCountDown(5);
            Console.WriteLine("Breath out...");
            DoCountDown(5);
        }
    }
}