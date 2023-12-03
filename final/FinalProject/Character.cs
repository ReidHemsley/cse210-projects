using System;

class Character
{
    public string _promptForAi = "";
    
    public string GenPrompt(string name)
    {
        _promptForAi = $"Make me a dungeons and Dragons character with " + name + " as the name";
        return _promptForAi;
    }
}