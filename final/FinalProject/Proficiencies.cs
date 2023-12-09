//For proficiencies and languages etc.

using System;

class Proficiencies : Character
{
    private string profPrompt;
    List<string> userProfs = new List<string>();
    List<string> userLangs = new List<string>();

    private string response;

    public void getUserOrAi()
    {
        Console.WriteLine("Write down any proficiencies you would like to character to have. Leave blank if you want random proficiencies.\n Type END when you have entered all the desired proficiencies.");
        response = Console.ReadLine();
        while (response.ToUpper() != "END" ^ response == "")
        {
            userProfs.Add(response);
            response = Console.ReadLine();
        }

        Console.WriteLine("Write down any languages you would like your character to know. Leave blank if you want random generated languages.\n Type END when you have entered all the desired languages.");
        response = Console.ReadLine();
        while (response.ToUpper() != "END" ^ response == "")
        {
            userLangs.Add(response);
            response = Console.ReadLine();
        }
    }

    public void setProfPrompt()
    {
        if (userProfs.Count > 0)
        {
            profPrompt = "The characters should include the following proficiencies: ";
            foreach (string prof in userProfs)
            {
                profPrompt += prof + ", ";
            }
            profPrompt.TrimEnd(' ');
            profPrompt.TrimEnd(',');
            profPrompt += ".";
            Console.WriteLine("Do you want to have a few random proficiencies added to your selection? [Y/N]");
            response = Console.ReadLine();
            if (response.ToUpper() == "Y" ^ userInput.ToUpper() == "YES")
            {
                profPrompt += "Generate a few more random proficiencies according to the characters class. ";
            }
            else if (response.ToUpper() == "N" ^ userInput.ToUpper() == "NO")
            {
                profPrompt += "Do not add any more proficiencies. ";
            }
            else
            {
                Console.WriteLine("Invalid response. Defaulted to No.");
                profPrompt += "Do not add any more proficiencies. ";
            }
        }
        else
        {
            profPrompt = "Give the character a few random proficiencies according to the characters class.";
        }

        if (userLangs.Count > 0)
        {
            profPrompt += "The characters should know the following language(s): ";
            foreach (string lang in userLangs)
            {
                profPrompt += lang + ", ";
            }
            profPrompt.TrimEnd(' ');
            profPrompt.TrimEnd(',');
            profPrompt += ".";
            Console.WriteLine("Do you want to have a couple random languages added to your selection? [Y/N]");
            response = Console.ReadLine();
            if (response.ToUpper() == "Y" ^ response.ToUpper() == "YES")
            {
                profPrompt += "Generate a few more random languages according to the characters class. ";
            }
            else if (response.ToUpper() == "N" ^ response.ToUpper() == "NO")
            {
                profPrompt += "Do not add any more languages. ";
            }
            else
            {
                Console.WriteLine("Invalid response. Defaulted to No.");
                profPrompt += "Do not add any more languages. ";
            }
        }
        else
        {
            profPrompt += "The character should know a few random languages according to the characters class.";
        }
    }
}