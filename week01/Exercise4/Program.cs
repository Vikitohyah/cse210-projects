using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        
        int inputedNumber = -1;
        while (inputedNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            inputedNumber = int.Parse(userInput);

            if (inputedNumber != 0)
            {
                numbers.Add(inputedNumber);
            }
        
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        double average = ((double)sum) / numbers.Count;
        int largest = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}