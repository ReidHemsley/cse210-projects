using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while(choice != -1)
        {
            Console.WriteLine("Mindfulness Activities:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Exit");
            Console.Write("Select an activity: ");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {

            } else if (choice == 2)
            {
                
            } else if (choice == 3)
            {
                
            } else if (choice == 4)
            {
                break;
            } else
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }
        }
    }
}