using System;
class Skills
{
    private string _skillsPrompt;
    List<string> userSkills = new List<string>();

    private string _response;

    public void getUserOrAi()
    {
        Console.WriteLine("Write down any skills you would like to character to have. Leave blank if you want random skills.\n Type END when you have entered all the desired skills. ");
        _response = Console.ReadLine();
        while (_response.ToUpper() != "END" ^ _response == "")
        {
            userSkills.Add(_response);
            _response = Console.ReadLine();
        }
    }

    public string setSkillsPrompt(bool doSkills)
    {
        _skillsPrompt = "";
        if(doSkills)
        {
            if (userSkills.Count > 0)
            {
                _skillsPrompt = "The characters should have the following skills: ";
                foreach (string skills in userSkills)
                {
                    _skillsPrompt += skills + ", ";
                }
                _skillsPrompt = _skillsPrompt.Remove(_skillsPrompt.Length - 2, 2);
                _skillsPrompt += ". ";
                Console.WriteLine("Do you want to have a few random skills added to your selection? [Y/N]");
                _response = Console.ReadLine();
                if (_response.ToUpper() == "Y" ^ _response.ToUpper() == "YES")
                {
                    _skillsPrompt += "Generate a few more random skills. ";
                }
                else if (_response.ToUpper() == "N" ^ _response.ToUpper() == "NO")
                {
                    _skillsPrompt += "Do not add any more skills. ";
                }
                else
                {
                    Console.WriteLine("Invalid _response. Defaulted to No. ");
                    _skillsPrompt += "Do not add any more skills. ";
                }
            }
            else
            {
                _skillsPrompt = "Give the character a few random skills according to the characters class. ";
            }
            
        }
        return _skillsPrompt;
    }
}