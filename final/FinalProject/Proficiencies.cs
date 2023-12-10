//For proficiencies and languages etc.

using System;

class Proficiencies
{
    private string _profPrompt;
    List<string> userProfs = new List<string>();
    List<string> userLangs = new List<string>();

    private string _response;

    public void getUserOrAi()
    {
        Console.WriteLine("Write down any proficiencies you would like to character to have. Leave blank if you want random proficiencies.\n Type END when you have entered all the desired proficiencies. ");
        _response = Console.ReadLine();
        while (_response.ToUpper() != "END" ^ _response == "")
        {
            userProfs.Add(_response);
            _response = Console.ReadLine();
        }

        Console.WriteLine("Write down any languages you would like your character to know. Leave blank if you want random generated languages.\n Type END when you have entered all the desired languages. ");
        _response = Console.ReadLine();
        while (_response.ToUpper() != "END" ^ _response == "")
        {
            userLangs.Add(_response);
            _response = Console.ReadLine();
        }
    }

    public string setProfPrompt(bool doProfAndLang)
    {
        if(doProfAndLang)
        getUserOrAi();
        {
            if (userProfs.Count > 0)
            {
                _profPrompt = "The characters should include the following proficiencies: ";
                foreach (string prof in userProfs)
                {
                    _profPrompt += prof + ", ";
                }
                _profPrompt = _profPrompt.Remove(_profPrompt.Length - 2, 2);
                _profPrompt += ". ";
                Console.WriteLine("Do you want to have a few random proficiencies added to your selection? [Y/N]");
                _response = Console.ReadLine();
                if (_response.ToUpper() == "Y" ^ _response.ToUpper() == "YES")
                {
                    _profPrompt += "Generate a few more random proficiencies according to the characters class. ";
                }
                else if (_response.ToUpper() == "N" ^ _response.ToUpper() == "NO")
                {
                    _profPrompt += "Do not add any more proficiencies. ";
                }
                else
                {
                    Console.WriteLine("Invalid _response. Defaulted to No. ");
                    _profPrompt += "Do not add any more proficiencies. ";
                }
            }
            else
            {
                _profPrompt = "Give the character a few random proficiencies according to the characters class. ";
            }

            if (userLangs.Count > 0)
            {
                _profPrompt += "The characters should know the following language(s): ";
                foreach (string lang in userLangs)
                {
                    _profPrompt += lang + ", ";
                }
                _profPrompt = _profPrompt.Remove(_profPrompt.Length - 2, 2);
                _profPrompt += ". ";
                Console.WriteLine("Do you want to have a couple random languages added to your selection? [Y/N]");
                _response = Console.ReadLine();
                if (_response.ToUpper() == "Y" ^ _response.ToUpper() == "YES")
                {
                    _profPrompt += "Generate a few more random languages according to the characters class. ";
                }
                else if (_response.ToUpper() == "N" ^ _response.ToUpper() == "NO")
                {
                    _profPrompt += "Do not add any more languages. ";
                }
                else
                {
                    Console.WriteLine("Invalid _response. Defaulted to No. ");
                    _profPrompt += "Do not add any more languages. ";
                }
            }
            else
            {
                _profPrompt += "The character should know a few random languages according to the characters class. ";
            }
        }
        return _profPrompt;
    }
}