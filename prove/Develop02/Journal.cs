using System;

class Journal
{
    public List<string> journalEntries = new List<string>();
    public string fileName;

    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (string savedEntry in journalEntries)
        {
            Console.WriteLine(savedEntry);
        }
    }

    public void SaveJournal()
    {
        Console.Write("What is the name of the file you want to save this journal to? ");
        fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (string savedEntry in journalEntries)
            {
                writer.WriteLine(savedEntry);
            }
        }
    }

    public void LoadJournal()
    {
        journalEntries.Clear();

        Console.Write("What is the name of the file you want to load from? ");
        fileName = Console.ReadLine();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                journalEntries.Add(line);
            }
        }
    }

    public void SaveEntry(string entry, string prompt)
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        string savedEntry = $"{date} - {prompt}: {entry}";
        journalEntries.Add(savedEntry);
    }

    public void Quit()
    {
        SaveJournal();
        Environment.Exit(0);
    }
}