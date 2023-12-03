using System;

class Program
{
    static void Main(string[] args)
    {
        Character test1 = new Character();

        Console.WriteLine("What is the name of your character?");
        string prompt = test1.GenPrompt(Console.ReadLine());
        Console.WriteLine("Here is your prompt. Put this into ChatGPT. ");
        Console.WriteLine(prompt);

    }
}