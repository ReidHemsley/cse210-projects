using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Scripture Scripture = new Scripture();
        Reference Reference = new Reference();
        string _input = "";
        Scripture.Initialize();

        int _scriptureIndex = Scripture.GetScriptureIndex();

        Console.Write(Reference.GetReference(_scriptureIndex));
        Console.WriteLine(Scripture.GetScripture());

        while (true){
            Console.WriteLine("\nPress Enter to hide words and type 'quit' to finish");
            _input = Console.ReadLine();
            if (_input == "quit")
            {
                break;
            }
            if (Scripture.UpdateScripture() == true)
            {
                break;
            }
            Console.Clear();
            Console.Write(Reference.GetReference(_scriptureIndex));
            Console.WriteLine(Scripture.GetUpdatedScripture());
        }
    }
    
}