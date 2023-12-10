using System;
using System.Security.Cryptography.X509Certificates;

class Stats
{
    private string _statsPrompt;

    // user inputed stats as strings
    private string _strength;
    private string _dexterity;
    private string _constitution;
    private string _intelligence;
    private string _wisdom;
    private string _rizz;
    private string _HP;
    private string _hitDice;
    //array with stats
    string[] stats = new string[8];
    //array with names
    string[] statNames = new string[] {"strength", "dexterity", "constitution", "intelligence", "wisdom", "charisma", "hit points", "hit dice"};
    public void getUserOrAi()
    {
        Console.WriteLine("Write what strength you would like your character to have OR leave blank and press ENTER if you want the strength stat to be randomly generated. ");
        _strength = Console.ReadLine();
        stats[0] = _strength;
        Console.WriteLine("Write what dexterity you would like your character to have OR leave blank and press ENTER if you want the dexterity stat to be randomly generated. ");
        _dexterity = Console.ReadLine();
        stats[1] = _dexterity;
        Console.WriteLine("Write what constitution you would like your character to have OR leave blank and press ENTER if you want the constitution stat to be randomly generated. ");
        _constitution = Console.ReadLine();
        stats[2] = _constitution;
        Console.WriteLine("Write what intelligence you would like your character to have OR leave blank and press ENTER if you want the intelligence stat to be randomly generated. ");
        _intelligence = Console.ReadLine();
        stats[3] = _intelligence;
        Console.WriteLine("Write what wisdom you would like your character to have OR leave blank and press ENTER if you want the wisdom stat to be randomly generated. ");
        _wisdom = Console.ReadLine();
        stats[4] = _wisdom;
        Console.WriteLine("Write what charisma you would like your character to have OR leave blank and press ENTER if you want the charisma stat to be randomly generated. ");
        _rizz = Console.ReadLine();
        stats[5] = _rizz;
        Console.WriteLine("Write what hit points you would like your character to have OR leave blank and press ENTER if you want the hit points stat to be randomly generated. ");
        _HP = Console.ReadLine();
        stats[6] = _HP;
        Console.WriteLine("Write what hit dice (i.e. 1d8) you would like your character to have OR leave blank and press ENTER if you want the hit dice stat to be randomly generated. ");
        _hitDice = Console.ReadLine();
        stats[7] = _hitDice;
    }

    public string setStatsPrompt(bool doStats)
    {
        _statsPrompt = "";
        if (doStats)
        {
            getUserOrAi();
            for (int i = 0; i < 8; i++)
            {
                if (stats[i] == "")
                {
                    _statsPrompt += $"Randomize the {statNames[i]} stat. ";
                }
                else
                {
                    _statsPrompt += $"The {statNames[i]} should be {stats[i]}. ";
                }
            }
        }
        return _statsPrompt;
    }
}