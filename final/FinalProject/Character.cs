using System;
using System.Reflection.Metadata;

class Character
{
    // Booleans used for whether or NOt to add specific details to the prompt.
    private bool doName;
    private bool doRace;
    private bool doBackstory;
    private bool doAlignment;
    private bool doStats;
    private bool doSkills;
    private bool doInventory;
    private bool doProfAndLang;
    private bool doEquipAndFeat;

    public string userInput = "";

    public void whatToGenerate()
    {
        // Checks if user wants a name to be included in prompt.
        Console.WriteLine("Would you like the prompt to include a name? [Y/N]");
        userInput = Console.ReadLine();
        if (userInput.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
        {
            doName = true;
        }
        else if (userInput.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
        {
            doName = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES.");
            doName = true;
        }

        // Checks if user wants a race to be included in prompt.
        Console.WriteLine("Would you like the prompt to include a race? [Y/N]");
        userInput = Console.ReadLine();
        if (userInput.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
        {
            doRace = true;
        }
        else if (userInput.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
        {
            doRace = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES.");
            doRace = true;
        }

        // Checks if user wants a backstory to be included in prompt.
        Console.WriteLine("Would you like the prompt to include a backstory? [Y/N]");
        userInput = Console.ReadLine();
        if (userInput.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
        {
            doBackstory = true;
        }
        else if (userInput.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
        {
            doBackstory = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES.");
            doBackstory = true;
        }

        // Checks if user wants an alignment to be included in prompt.
        Console.WriteLine("Would you like the prompt to include an alignment? [Y/N]");
        userInput = Console.ReadLine();
        if (userInput.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
        {
            doAlignment = true;
        }
        else if (userInput.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
        {
            doAlignment = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES.");
            doAlignment = true;
        }

        // Checks if user wants stats to be included in prompt.
        Console.WriteLine("Would you like the prompt to include stats (hp, constatution, intelligenct, etc.)? [Y/N]");
        userInput = Console.ReadLine();
        if (userInput.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
        {
            doStats = true;
        }
        else if (userInput.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
        {
            doStats = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES.");
            doStats = true;
        }

        // Checks if user wants skills to be included in prompt.
        Console.WriteLine("Would you like the prompt to include a skills? [Y/N]");
        userInput = Console.ReadLine();
        if (userInput.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
        {
            doSkills = true;
        }
        else if (userInput.ToUpper().ToUpper() == "N" ^ userInput.ToUpper() == "NO")
        {
            doSkills = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES.");
            doSkills = true;
        }

        // Checks if user wants an inventory to be included in prompt.
        Console.WriteLine("Would you like the prompt to include an inventory? [Y/N]");
        userInput = Console.ReadLine();
        if (userInput.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
        {
            doInventory = true;
        }
        else if (userInput.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
        {
            doInventory = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES.");
            doInventory = true;
        }

        // Checks if user wants proficiencies and spoken languages to be included in prompt.
        Console.WriteLine("Would you like the prompt to include proficiencies and languages? [Y/N]");
        userInput = Console.ReadLine();
        if (userInput.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
        {
            doProfAndLang = true;
        }
        else if (userInput.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
        {
            doProfAndLang = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES.");
            doProfAndLang = true;
        }

        // Checks if user wants equiptment, feats and features to be included in prompt.
        Console.WriteLine("Would you like the prompt to include equipment, feats and features? [Y/N]");
        userInput = Console.ReadLine();
        if (userInput.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
        {
            doEquipAndFeat = true;
        }
        else if (userInput.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
        {
            doEquipAndFeat = false;
        }
        else
        {
            Console.WriteLine("Invalid response. Defaulted to YES.");
            doEquipAndFeat = true;
        }

    }

}