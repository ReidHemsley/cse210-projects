/*

*Journal Project Outline*

PromptOptions()
{
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Save & Quit");
    Console.Write("What would you like to do?");
    _userChoice = Console.ReadLine();

}

if (_userChoice = 1)
{
    Entry()
}
elif (_userChoice = 2)
{
    DisplayJournal()
}
elif (_userChoice = 3)
{
    SaveJournal()
}
elif (_userChoice = 4)
{
    LoadJournal()
}
elif (_userChoice = 5)
{
    Quit()
}

GeneratePrompt()
{
    _allPrompts = []
    _prompt = _allPrompts[random]
    Console.WriteLine(prompt);
}

updateJournal(_savedEntry)
{
    _journalEntries = []
    _journalEntries.Add(_savedEntry)
}

SaveEntry(_entry, _prompt)
{
    _savedEntry = _date + _prompt + _entry
    updateJournal(_savedEntry)
}

Entry()
{
    GeneratePrompt()
    _entry = Console.ReadLine();
    SaveEntry()
}

DisplayJournal()
{
    foreach (_savedEntry in _journalEntries)
        Console.WriteLine(_savedEntry);
}

SaveJournal()
{
    console.write("What is the name of the file you want to save this journal to?)
    _fileName = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(_fileName))
    {
        foreach (var _savedEntry in _journalEntries)
        {
            writer.WriteLine($"{_savedEntry} |");
        }
}

LoadJournal()
{
    _journalEntries.Clear()
    
    console.write("What is the name of the file you want to load from?)
    _fileName = Console.ReadLine();

    using (StreamReader reader = new StreamReader(_fileName))
    {
        string line;
            while ((line = reader.ReadLine()) != null)
            {
                string _entry = line.Split('|');
                _journalEntries.Add(new _entry)
    }
}

Quit()
{
    SaveJournal()
    Exit()
}
*/