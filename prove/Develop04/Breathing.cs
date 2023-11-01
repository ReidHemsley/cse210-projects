using System;

class Breathing : Activity
{
    public Breathing() : base("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    
    protected void DoActivity(int duration)
    {
        Console.WriteLine("Follow the instuctions. We will begin in ");
        DoCountDown(5);
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breath in...");
            DoCountDown(5);
            Console.WriteLine("Breath out...");
            DoCountDown(5);
        }
    }
}