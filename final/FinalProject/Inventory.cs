//For items in inventory i.e. Weapons, potions, artifacts, currency, etc.

using System;

class Inventory
{
    List<string> _userInv = new List<string>();
    private string _invPrompt;
    private string _response;

    public void getUserOrAi()
    {
        Console.WriteLine("Write down any items you would like to include in your characters inventory (Weapons, potions, currency, etc.). Leave blank if you want random generated items in the characters inventory.\n Type END when you have entered all the desired items. ");
        _response = Console.ReadLine();
        while (_response.ToUpper() != "END" ^ _response == "")
        {
            _userInv.Add(_response);
            _response = Console.ReadLine();
        }
    }

    public string setInvPrompt(bool doInventory)
    {
        if(doInventory)
        {
            getUserOrAi();
            if (_userInv.Count > 0)
            {
                _invPrompt = "The characters inventory should include the following items: ";
                foreach (string item in _userInv)
                {
                    _invPrompt += item + ", ";
                }
                _invPrompt = _invPrompt.Remove(_invPrompt.Length - 2, 2);
                _invPrompt += ". ";
                Console.WriteLine("Do you want to have random generated items added to your selection? [Y/N]");
                _response = Console.ReadLine();
                if (_response.ToUpper() == "Y" ^ _response.ToUpper() == "YES")
                {
                    _invPrompt += "Generate a few more items for the inventory";
                }
                else if (_response.ToUpper() == "N" ^ _response.ToUpper() == "NO")
                {
                    _invPrompt += "Do not add items to the inventory";
                }
                else
                {
                    Console.WriteLine("Invalid _response. Defaulted to No. ");
                    _invPrompt += "Do not add items to the inventory";
                }
            }
            else
            {
                _invPrompt = "Add a few items such as weapons, potions, artifacts, currency, etc. to the characters inventory. ";
            }
        }
        return _invPrompt;
    }
    
}