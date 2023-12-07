using System;

class Stats : Character
{
    private string statsPrompt;

    // bools for if the stat is randomized or not
    private bool randomCons;
    private bool randomIntel;
    private bool randomWis;
    private bool randomRizz;
    private bool randomDex;
    private bool randomHP;
    private bool randomHDice;

    // user inputed stats as strings
    private string strength;
    private string dexterity;
    private string constitution;
    private string intelligence;
    private string wisdom;
    private string rizz;
    private string HP;
    private string hitDice;
    public void getUserOrAi()
    {
        Console.WriteLine("Write what strength you would like your character to have OR leave blank and press ENTER if you want the strength stat to be randomly generated.");
        strength = Console.ReadLine();
        Console.WriteLine("Write what dexterity you would like your character to have OR leave blank and press ENTER if you want the dexterity stat to be randomly generated.");
        dexterity = Console.ReadLine();
        Console.WriteLine("Write what constitution you would like your character to have OR leave blank and press ENTER if you want the constitution stat to be randomly generated.");
        constitution = Console.ReadLine();
        Console.WriteLine("Write what intelligence you would like your character to have OR leave blank and press ENTER if you want the intelligence stat to be randomly generated.");
        intelligence = Console.ReadLine();
        Console.WriteLine("Write what wisdom you would like your character to have OR leave blank and press ENTER if you want the wisdom stat to be randomly generated.");
        wisdom = Console.ReadLine();
        Console.WriteLine("Write what charisma you would like your character to have OR leave blank and press ENTER if you want the charisma stat to be randomly generated.");
        rizz = Console.ReadLine();
        Console.WriteLine("Write what hit points you would like your character to have OR leave blank and press ENTER if you want the hit points stat to be randomly generated.");
        HP = Console.ReadLine();
        Console.WriteLine("Write what hit dice (i.e. 1d8) you would like your character to have OR leave blank and press ENTER if you want the hit dice stat to be randomly generated.");
        hitDice = Console.ReadLine();
    }

    public string setStatsPrompt(string str, string dex, string cons, string intel, string wis, string riz, string hp, string dice)
    {
        if (str == "")
        {

        }
        else
        {

        }
        return statsPrompt;
    }

}