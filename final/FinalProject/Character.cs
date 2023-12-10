using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Character
{
    // Booleans used for whether or NOt to add specific details to the prompt.
    private bool _doName;
    private bool _doRace;
    private bool _doBackstory;
    private bool _doStats;
    private bool _doSkills;
    private bool _doInventory;
    private bool _doProfAndLang;
    private bool _doEquipAndFeat;

    public string _finalPrompt;

    public string _userInput;

    Class class1 = new Class();
    Characteristics char1 = new Characteristics();
    Stats stats1 = new Stats();
    Skills skills1 = new Skills();
    Proficiencies prof1 = new Proficiencies();
    Inventory inv1 = new Inventory();
    Feats feats1 = new Feats();
    

    public void whatToGenerate()
    {
        // Checks if user wants a name to be included in prompt.
        Console.WriteLine("Would you like the prompt to include a name? [Y/N]");
        _userInput = Console.ReadLine();
        if (_userInput.ToUpper() == "Y" ^ _userInput.ToUpper() == "YES")
        {
            _doName = true;
        }
        else if (_userInput.ToUpper() == "N" ^ _userInput.ToUpper() == "NO")
        {
            _doName = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES. ");
            _doName = true;
        }

        // Checks if user wants a race to be included in prompt.
        Console.WriteLine("Would you like the prompt to include a race? [Y/N]");
        _userInput = Console.ReadLine();
        if (_userInput.ToUpper() == "Y" ^ _userInput.ToUpper() == "YES")
        {
            _doRace = true;
        }
        else if (_userInput.ToUpper() == "N" ^ _userInput.ToUpper() == "NO")
        {
            _doRace = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES. ");
            _doRace = true;
        }

        // Checks if user wants a backstory to be included in prompt.
        Console.WriteLine("Would you like the prompt to include a backstory? [Y/N]");
        _userInput = Console.ReadLine();
        if (_userInput.ToUpper() == "Y" ^ _userInput.ToUpper() == "YES")
        {
            _doBackstory = true;
        }
        else if (_userInput.ToUpper() == "N" ^ _userInput.ToUpper() == "NO")
        {
            _doBackstory = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES. ");
            _doBackstory = true;
        }

        // Checks if user wants stats to be included in prompt.
        Console.WriteLine("Would you like the prompt to include stats (hp, constatution, intelligenct, etc.)? [Y/N]");
        _userInput = Console.ReadLine();
        if (_userInput.ToUpper() == "Y" ^ _userInput.ToUpper() == "YES")
        {
            _doStats = true;
        }
        else if (_userInput.ToUpper() == "N" ^ _userInput.ToUpper() == "NO")
        {
            _doStats = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES. ");
            _doStats = true;
        }

        // Checks if user wants skills to be included in prompt.
        Console.WriteLine("Would you like the prompt to include skills? [Y/N]");
        _userInput = Console.ReadLine();
        if (_userInput.ToUpper() == "Y" ^ _userInput.ToUpper() == "YES")
        {
            _doSkills = true;
        }
        else if (_userInput.ToUpper().ToUpper() == "N" ^ _userInput.ToUpper() == "NO")
        {
            _doSkills = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES. ");
            _doSkills = true;
        }

        // Checks if user wants an inventory to be included in prompt.
        Console.WriteLine("Would you like the prompt to include an inventory? [Y/N]");
        _userInput = Console.ReadLine();
        if (_userInput.ToUpper() == "Y" ^ _userInput.ToUpper() == "YES")
        {
            _doInventory = true;
        }
        else if (_userInput.ToUpper() == "N" ^ _userInput.ToUpper() == "NO")
        {
            _doInventory = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES. ");
            _doInventory = true;
        }

        // Checks if user wants proficiencies and spoken languages to be included in prompt.
        Console.WriteLine("Would you like the prompt to include proficiencies and languages? [Y/N]");
        _userInput = Console.ReadLine();
        if (_userInput.ToUpper() == "Y" ^ _userInput.ToUpper() == "YES")
        {
            _doProfAndLang = true;
        }
        else if (_userInput.ToUpper() == "N" ^ _userInput.ToUpper() == "NO")
        {
            _doProfAndLang = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES. ");
            _doProfAndLang = true;
        }

        // Checks if user wants equiptment, feats and features to be included in prompt.
        Console.WriteLine("Would you like the prompt to include equipment, feats and features? [Y/N]");
        _userInput = Console.ReadLine();
        if (_userInput.ToUpper() == "Y" ^ _userInput.ToUpper() == "YES")
        {
            _doEquipAndFeat = true;
        }
        else if (_userInput.ToUpper() == "N" ^ _userInput.ToUpper() == "NO")
        {
            _doEquipAndFeat = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES. ");
            _doEquipAndFeat = true;
        }
        Console.Clear();
    }


    public string getPrompts()
    {
        _finalPrompt = "Make me a D&D character with these inputs. ";
        _finalPrompt += class1.setClassPrompt();
        _finalPrompt += char1.setCharPrompt(_doName, _doRace, _doBackstory);
        _finalPrompt += stats1.setStatsPrompt(_doStats);
        _finalPrompt += skills1.setSkillsPrompt(_doSkills);
        _finalPrompt += prof1.setProfPrompt(_doProfAndLang);
        _finalPrompt += inv1.setInvPrompt(_doInventory);
        _finalPrompt += feats1.setFeatsPrompt(_doEquipAndFeat);
        Console.WriteLine($"Here is your final prompt.\n \n{_finalPrompt}\n");
        return _finalPrompt;
    }

    public string getFinalPrompt()
    {
        return _finalPrompt;
    }

}