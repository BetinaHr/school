using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separated by spaces:");
        string input = Console.ReadLine(); 
        string[] numbers = input.Split(' ');

        int sum = 0;
        foreach (string num in numbers)
        {
            if (int.TryParse(num, out int n))
            {
                sum += n;
            }
            else
            {
                Console.WriteLine($"'{num}' is not a valid number.");
            }
        }

        Console.WriteLine($"The sum of the numbers is: {sum}");
    }
}
