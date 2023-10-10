using System;

class Entry
{
    public static void WriteEntry(Journal journal)
    {
        string prompt = GeneratePrompt();
        Console.Write($"'{prompt}' ");
        string entry = Console.ReadLine();
        journal.SaveEntry(entry, prompt);
    }

    public static string GeneratePrompt()
    {
        List<string> prompts = new List<string> {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
        var random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }
}
