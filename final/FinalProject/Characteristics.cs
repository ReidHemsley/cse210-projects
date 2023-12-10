//For characteristics i.e. Name, Height, Weight, eyecolor, etc.

using System;
using System.Dynamic;
using System.Globalization;
using System.Xml;

class Characteristics
{
    public string _characteristicsPrompt;
    private string _race;
    private string _name;
    private string _backstory;

    public string setCharPrompt(bool doName, bool doRace, bool doBackstory)
    {
        _characteristicsPrompt = "";
    
        if (doName)
        {
            Console.WriteLine("What do you want the characters name to be? Leave blank for a random name. ");
            _name = Console.ReadLine();
            if (_name == "")
            {
                _characteristicsPrompt += "Give the character a random first and last name. ";
            }
            else
            {
                _characteristicsPrompt += "The name of the character is " + _name + ". ";
            }
        }
        
        if (doRace)
        {
            Console.WriteLine("What do you want the characters race to be? Leave blank for a random race. ");
            _race = Console.ReadLine();
            if (_race == "")
            {
                _characteristicsPrompt += "Make the character a random race. ";
            }
            else
            {
                _characteristicsPrompt += "The race of the character should be " + _race + ". ";
            }
        }
        
        if (doBackstory)
        {
            Console.WriteLine("Write a brief backstory, or leave blank for a random backstory. ");
            _backstory = Console.ReadLine();
            if (_backstory == "")
            {
                _characteristicsPrompt += "Generate a brief backstory for the character. ";
            }
            else
            {
                _characteristicsPrompt += "Here is a brief backstory for the character. " + _backstory + ". ";
            }
        }
    
        return _characteristicsPrompt;
    }
}