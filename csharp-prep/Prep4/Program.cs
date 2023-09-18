using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        int sum = 0;
        int large = 0;

        while (number != 0)
        {
            Console.Write("Type a number to add to list: ");
            string numStr = Console.ReadLine();
            number = int.Parse(numStr);
            
            if (number != 0)
            {
            numbers.Add(number);
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > large)
            {
                large = numbers[i];
            }
        }
        
        float average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {large}");


    }
}