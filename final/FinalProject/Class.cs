using System;

class Class
{
    private string _classPrompt;
    private string _userInput;
    public void getUserOrAi()
    {
        Console.WriteLine("Write what class you would like your character to be OR leave blank and press ENTER if you want the class to be randomly generated. ");
        _userInput = Console.ReadLine();
    }

    public string setClassPrompt()
    {
        getUserOrAi();
        if (_userInput == "")
        {
            _classPrompt = "Give the character a random class. ";
        }
        else
        {
            _classPrompt = $"The character should be a {_userInput} class. ";
        }
        return _classPrompt;
    }

}