using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string _choice = "";
        Console.WriteLine("Press ENTER to create new character. Type 'quit' to finish. ");
        _choice = Console.ReadLine();
        while (_choice == "")
        {
            Character character1 = new Character();

            character1.whatToGenerate();
            character1.getPrompts();

            // Save prompt to file
            Console.Write("What file would you like to save your current prompt to? (.txt is recommended)");
            string _fileName = Console.ReadLine();
            Save.SavePrompt(character1.getFinalPrompt(), _fileName);
            
            // Check if user wants to create another character.
            Console.WriteLine("Press ENTER to create new character. Type 'quit' to finish. ");
            _choice = Console.ReadLine();
        }


    }
}