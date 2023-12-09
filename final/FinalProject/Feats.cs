//For Features, feats, and equipment.

using System;

class Feats : Character
{
    private string featsPrompt;
    List<string> userEquip = new List<string>();
    List<string> userFeats = new List<string>();
    List<string> userFeatures = new List<string>();

    private string response;

    public void getUserOrAi()
    {
        Console.WriteLine("Write down any equipment you would like to character to have. Leave blank if you want random equipment.\n Type END when you have entered all the desired equipment.");
        response = Console.ReadLine();
        while (response.ToUpper() != "END" ^ response == "")
        {
            userEquip.Add(response);
            response = Console.ReadLine();
        }

        Console.WriteLine("Write down any feats you would like your character to have. Leave blank if you want random generated feats.\n Type END when you have entered all the desired feats.");
        response = Console.ReadLine();
        while (response.ToUpper() != "END" ^ response == "")
        {
            userFeats.Add(response);
            response = Console.ReadLine();
        }

        Console.WriteLine("Write down any features you would like your character to have. Leave blank if you want random generated features.\n Type END when you have entered all the desired features.");
        response = Console.ReadLine();
        while (response.ToUpper() != "END" ^ response == "")
        {
            userFeatures.Add(response);
            response = Console.ReadLine();
        }
    }

    public void setProfPrompt()
    {
        if (userEquip.Count > 0)
        {
            featsPrompt = "The character should include the following equipment: ";
            foreach (string equip in userEquip)
            {
                featsPrompt += equip + ", ";
            }
            featsPrompt.TrimEnd(' ');
            featsPrompt.TrimEnd(',');
            featsPrompt += ".";
            Console.WriteLine("Do you want to have a few random pieces of equipment added to your selection? [Y/N]");
            response = Console.ReadLine();
            if (response.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
            {
                featsPrompt += "Generate a few more random pieces of equipment according to the characters class. ";
            }
            else if (response.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
            {
                featsPrompt += "Do not add any more equipment. ";
            }
            else
            {
                Console.WriteLine("Invalid response. Defaulted to No.");
                featsPrompt += "Do not add any more equipment. ";
            }
        }
        else
        {
            featsPrompt = "Give the character a few random pieces of equipment according to the characters class.";
        }

        if (userFeats.Count > 0)
        {
            featsPrompt += "The character should include the following feats: ";
            foreach (string feats in userFeats)
            {
                featsPrompt += feats + ", ";
            }
            featsPrompt.TrimEnd(' ');
            featsPrompt.TrimEnd(',');
            featsPrompt += ".";
            Console.WriteLine("Do you want to have a couple random feats added to your selection? [Y/N]");
            response = Console.ReadLine();
            if (response.ToUpper() == "Y" ^ response.ToUpper() == "YES")
            {
                featsPrompt += "Generate a few more random feats according to the characters class. ";
            }
            else if (response.ToUpper() == "N" ^ response.ToUpper() == "NO")
            {
                featsPrompt += "Do not add any more feats. ";
            }
            else
            {
                Console.WriteLine("Invalid response. Defaulted to No.");
                featsPrompt += "Do not add any more feats. ";
            }
        }
        else
        {
            featsPrompt += "Give the character a few random feats according to the characters class.";
        }

        if (userFeatures.Count > 0)
        {
            featsPrompt += "The character should include the following features: ";
            foreach (string features in userFeatures)
            {
                featsPrompt += features + ", ";
            }
            featsPrompt.TrimEnd(' ');
            featsPrompt.TrimEnd(',');
            featsPrompt += ".";
            Console.WriteLine("Do you want to have a couple random features added to your selection? [Y/N]");
            response = Console.ReadLine();
            if (response.ToUpper() == "Y" ^ response.ToUpper() == "YES")
            {
                featsPrompt += "Generate a few more random features according to the characters class. ";
            }
            else if (response.ToUpper() == "N" ^ response.ToUpper() == "NO")
            {
                featsPrompt += "Do not add any more features. ";
            }
            else
            {
                Console.WriteLine("Invalid response. Defaulted to No.");
                featsPrompt += "Do not add any more features. ";
            }
        }
        else
        {
            featsPrompt += "Give the character a few random features according to the characters class.";
        }
    }
}