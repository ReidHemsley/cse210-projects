//For Features, feats, and equipment.

using System;

class Feats
{
    private string _featsPrompt;
    List<string> _userEquip = new List<string>();
    List<string> _userFeats = new List<string>();
    List<string> _userFeatures = new List<string>();

    private string _response;

    public void getUserOrAi()
    {
        Console.WriteLine("Write down any equipment you would like to character to have. Leave blank if you want random equipment.\n Type END when you have entered all the desired equipment. ");
        _response = Console.ReadLine();
        while (_response.ToUpper() != "END" ^ _response == "")
        {
            _userEquip.Add(_response);
            _response = Console.ReadLine();
        }

        Console.WriteLine("Write down any feats you would like your character to have. Leave blank if you want random generated feats.\n Type END when you have entered all the desired feats. ");
        _response = Console.ReadLine();
        while (_response.ToUpper() != "END" ^ _response == "")
        {
            _userFeats.Add(_response);
            _response = Console.ReadLine();
        }

        Console.WriteLine("Write down any features you would like your character to have. Leave blank if you want random generated features.\n Type END when you have entered all the desired features. ");
        _response = Console.ReadLine();
        while (_response.ToUpper() != "END" ^ _response == "")
        {
            _userFeatures.Add(_response);
            _response = Console.ReadLine();
        }
    }

    public string setFeatsPrompt(bool doEquipAndFeat)
    {
        if(doEquipAndFeat)
        {
            getUserOrAi();
            if (_userEquip.Count > 0)
            {
                _featsPrompt = "The character should include the following equipment: ";
                foreach (string equip in _userEquip)
                {
                    _featsPrompt += equip + ", ";
                }
                _featsPrompt = _featsPrompt.Remove(_featsPrompt.Length - 2, 2);
                _featsPrompt += ". ";
                Console.WriteLine("Do you want to have a few random pieces of equipment added to your selection? [Y/N]");
                _response = Console.ReadLine();
                if (_response.ToUpper() == "Y" ^ _response.ToUpper() == "YES")
                {
                    _featsPrompt += "Generate a few more random pieces of equipment according to the characters class. ";
                }
                else if (_response.ToUpper() == "N" ^ _response.ToUpper() == "NO")
                {
                    _featsPrompt += "Do not add any more equipment. ";
                }
                else
                {
                    Console.WriteLine("Invalid _response. Defaulted to No. ");
                    _featsPrompt += "Do not add any more equipment. ";
                }
            }
            else
            {
                _featsPrompt = "Give the character a few random pieces of equipment according to the characters class. ";
            }

            if (_userFeats.Count > 0)
            {
                _featsPrompt += "The character should include the following feats: ";
                foreach (string feats in _userFeats)
                {
                    _featsPrompt += feats + ", ";
                }
                _featsPrompt = _featsPrompt.Remove(_featsPrompt.Length - 2, 2);
                _featsPrompt += ". ";
                Console.WriteLine("Do you want to have a couple random feats added to your selection? [Y/N]");
                _response = Console.ReadLine();
                if (_response.ToUpper() == "Y" ^ _response.ToUpper() == "YES")
                {
                    _featsPrompt += "Generate a few more random feats according to the characters class. ";
                }
                else if (_response.ToUpper() == "N" ^ _response.ToUpper() == "NO")
                {
                    _featsPrompt += "Do not add any more feats. ";
                }
                else
                {
                    Console.WriteLine("Invalid _response. Defaulted to No. ");
                    _featsPrompt += "Do not add any more feats. ";
                }
            }
            else
            {
                _featsPrompt += "Give the character a few random feats according to the characters class. ";
            }

            if (_userFeatures.Count > 0)
            {
                _featsPrompt += "The character should include the following features: ";
                foreach (string features in _userFeatures)
                {
                    _featsPrompt += features + ", ";
                }
                _featsPrompt = _featsPrompt.Remove(_featsPrompt.Length - 2, 2);
                _featsPrompt += ". ";
                Console.WriteLine("Do you want to have a couple random features added to your selection? [Y/N]");
                _response = Console.ReadLine();
                if (_response.ToUpper() == "Y" ^ _response.ToUpper() == "YES")
                {
                    _featsPrompt += "Generate a few more random features according to the characters class. ";
                }
                else if (_response.ToUpper() == "N" ^ _response.ToUpper() == "NO")
                {
                    _featsPrompt += "Do not add any more features. ";
                }
                else
                {
                    Console.WriteLine("Invalid _response. Defaulted to No. ");
                    _featsPrompt += "Do not add any more features. ";
                }
            }
            else
            {
                _featsPrompt += "Give the character a few random features according to the characters class. ";
            }
        }
        return _featsPrompt;
    }
}