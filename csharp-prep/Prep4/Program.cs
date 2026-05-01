using System;
using System.Globalization;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();

        Console.WriteLine("Add some numbers to a list. When you are done type 0");
        
        int userInput = -1;
        
        while (userInput != 0)
        {
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        if (numbers.Count > 0)
        {
            double mean = (double)sum / numbers.Count;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {mean}");
        }
        else
        {
            Console.WriteLine("No numbers were entered");
        }
    }
}