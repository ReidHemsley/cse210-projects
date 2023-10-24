using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Reid", "Numbers n Stuff");
        Console.WriteLine(assignment1.GetSummary());

        Math assignment2 = new Math("Jonas", "Letters Meet Numbers", "3", "1-10");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        Writing assignment3 = new Writing("Josh", "Handwriting", "Simplified Cursive");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInfo());
    }
}