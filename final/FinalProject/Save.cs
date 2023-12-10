using System;

class Save
{
    public static void SavePrompt(string prompt, string filename)
    {

        using (StreamWriter writer = File.AppendText(filename))
        {
            writer.WriteLine(prompt);
        }
    }
}