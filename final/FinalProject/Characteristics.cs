//For characteristics i.e. Name, Height, Weight, eyecolor, etc.

using System;
using System.Dynamic;
using System.Globalization;
using System.Xml;

class Characteristics : Character
{
    public string characteristicsPrompt;
    private string race;
    private string name;
    private string backstory;
    private bool charactaristic = true;

    string[] characteristics = new string[3];
    
    //characteristic names in list
    private string[] characteristicNames = new string[] {"name", "race", "backstory"};


    public void GetUserOrAi()
    {
        for (int i = 0; i < 3; i++)
        {
            if (charactaristic == true)
            {
                if (characteristicNames[i] == "name")
                {
                    Console.WriteLine("What do you want the characters name to be? Leave blank for for a random name.");
                    name = Console.ReadLine();
                    characteristics[0] = name;
                }
                else if (characteristicNames[i] == "race")
                {
                    Console.WriteLine("What do you want the characters race to be? Leave blank for for a random race.");
                    race = Console.ReadLine();
                    characteristics[1]= race;
                }
                else if (characteristicNames[i] == "backstory")
                {
                    Console.WriteLine("Write down a breif backstory for the character or, leave blank for a backstory to be randomly generated.");
                    backstory = Console.ReadLine();
                    characteristics[2] = backstory;
                }
            }
        }
    }
    public string setCharPrompt()
    {
        characteristicsPrompt = "";
        for (int i = 0; i < 8; i++)
        {
            if (characteristics[i] == "")
            {
                if (characteristicNames[i] == "backstory")
                {
                    characteristicsPrompt += $"Give the player breif backstory based on its characteristics.";
                }
                else
                {
                    characteristicsPrompt += $"Randomize the characters {characteristicNames[i]}";
                }
            }
            else
            {
                characteristicsPrompt += $"The {characteristicNames[i]} of the character should be {characteristics[i]}";
            }
        }
        return characteristicsPrompt;
    }
}