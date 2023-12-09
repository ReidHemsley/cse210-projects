//For items in inventory i.e. Weapons, potions, artifacts, currency, etc.

using System;

class Inventory : Character
{
    List<string> userInv = new List<string>();
    private string invPrompt;
    private string response;

    public void getUserOrAi()
    {
        Console.WriteLine("Write down any items you would like to include in your characters inventory (Weapons, potions, currency, etc.). Leave blank if you want random generated items in the characters inventory.\n Type END when you have entered all the desired items.");
        response = Console.ReadLine();
        while (response.ToUpper() != "END" ^ response == "")
        {
            userInv.Add(response);
            response = Console.ReadLine();
        }
    }

    public void setInvPrompt()
    {
        if (userInv.Count > 0)
        {
            invPrompt = "The characters inventory should include the following items: ";
            foreach (string item in userInv)
            {
                invPrompt += item + ", ";
            }
            invPrompt.TrimEnd(' ');
            invPrompt.TrimEnd(',');
            invPrompt += ".";
            Console.WriteLine("Do you want to have random generated items added to your selection? [Y/N]");
            response = Console.ReadLine();
            if (response.ToUpper() == "Y" ^ response.ToUpper() == "YES")
            {
                invPrompt += "Generate a few more items for the inventory";
            }
            else if (response.ToUpper() == "N" ^ response.ToUpper() == "NO")
            {
                invPrompt += "Do not add items to the inventory";
            }
            else
            {
                Console.WriteLine("Invalid response. Defaulted to No.");
                invPrompt += "Do not add items to the inventory";
            }
        }
        else
        {
            invPrompt = "Add a few items such as weapons, potions, artifacts, currency, etc. to the characters inventory.";
        }
    }
    
}