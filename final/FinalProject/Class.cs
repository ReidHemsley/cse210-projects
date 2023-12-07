using System;

class Class : Character
{
    private string classPrompt;
    private bool randomPrompt;
    public void getUserOrAi()
    {
        Console.WriteLine("Write what class you would like your character to be OR leave blank and press ENTER if you want the class to be randomly generated.");
        string userInput = Console.ReadLine();
    }

    public string setClassPrompt(string userInput)
    {
        if (userInput == "")
        {
            classPrompt = ", give them a random class";
            randomPrompt = true;
        }
        else
        {
            classPrompt = userInput;
            randomPrompt = false;
        }
        return classPrompt;
    }

}