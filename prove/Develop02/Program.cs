using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string _choice = "";

        while (_choice != "5")
        {
            DisplayMenu();
            _choice = Console.ReadLine();

            if (_choice == "1")
            {
                Entry.WriteEntry(journal);
            } else if (_choice == "2")
            {
                journal.DisplayJournal();
            } else if (_choice == "3")
            {
                journal.SaveJournal();
            } else if (_choice == "4")
            {
                journal.LoadJournal();
            } else if (_choice == "5")
            {
                journal.Quit();
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Save & Quit");
        Console.Write("What would you like to do? ");

    }
}