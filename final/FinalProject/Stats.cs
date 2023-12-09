using System;
using System.Security.Cryptography.X509Certificates;

class Stats : Character
{
    private string statsPrompt;

    // user inputed stats as strings
    private string strength;
    private string dexterity;
    private string constitution;
    private string intelligence;
    private string wisdom;
    private string rizz;
    private string HP;
    private string hitDice;
    //array with stats
    string[] stats = new string[8];
    //array with names
    string[] statNames = new string[] {"strength", "dexterity", "constitution", "intelligence", "wisdom", "charisma", "hit points", "hit dice"};
    public void getUserOrAi()
    {
        Console.WriteLine("Write what strength you would like your character to have OR leave blank and press ENTER if you want the strength stat to be randomly generated.");
        strength = Console.ReadLine();
        stats[0] = strength;
        Console.WriteLine("Write what dexterity you would like your character to have OR leave blank and press ENTER if you want the dexterity stat to be randomly generated.");
        dexterity = Console.ReadLine();
        stats[1] = dexterity;
        Console.WriteLine("Write what constitution you would like your character to have OR leave blank and press ENTER if you want the constitution stat to be randomly generated.");
        constitution = Console.ReadLine();
        stats[2] = constitution;
        Console.WriteLine("Write what intelligence you would like your character to have OR leave blank and press ENTER if you want the intelligence stat to be randomly generated.");
        intelligence = Console.ReadLine();
        stats[3] = intelligence;
        Console.WriteLine("Write what wisdom you would like your character to have OR leave blank and press ENTER if you want the wisdom stat to be randomly generated.");
        wisdom = Console.ReadLine();
        stats[4] = wisdom;
        Console.WriteLine("Write what charisma you would like your character to have OR leave blank and press ENTER if you want the charisma stat to be randomly generated.");
        rizz = Console.ReadLine();
        stats[5] = rizz;
        Console.WriteLine("Write what hit points you would like your character to have OR leave blank and press ENTER if you want the hit points stat to be randomly generated.");
        HP = Console.ReadLine();
        stats[6] = HP;
        Console.WriteLine("Write what hit dice (i.e. 1d8) you would like your character to have OR leave blank and press ENTER if you want the hit dice stat to be randomly generated.");
        hitDice = Console.ReadLine();
        stats[7] = hitDice;
    }

    public string setStatsPrompt()
    {
        statsPrompt = "";
        for (int i = 0; i < 8; i++)
        {
            if (stats[i] == "")
            {
                statsPrompt += $"Randomize the {statNames[i]} stat.";
            }
            else
            {
                statsPrompt += $"The {statNames[i]} should be {stats[i]}";
            }
        }
        return statsPrompt;
    }

}