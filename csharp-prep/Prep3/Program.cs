using System;
using System.ComponentModel;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        int guess = 0;

        while (guess != number)
        {
            Console.Write("Enter your guess (1-100): ");
            string guessStr = Console.ReadLine();
            guess = int.Parse(guessStr);

            if (guess > number)
            {
                Console.WriteLine("Lower");
            } else if (guess < number)
            {
                Console.WriteLine("Higher");
            } else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}