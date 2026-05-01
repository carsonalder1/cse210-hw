using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        float magicNumber = float.Parse(Console.ReadLine());
        
        float guessNumber;

        do
        {
            Console.WriteLine("What is your guess?");
            guessNumber = float.Parse(Console.ReadLine());
            {
            if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                    
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            }
        } while (guessNumber != magicNumber);

        Console.WriteLine("You Got It!");
    }
}