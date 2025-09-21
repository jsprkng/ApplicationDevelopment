using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("This program performs sorting in descending order.");
        Console.Write("How many numbers do you want to sort? ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (numbers[j] < numbers[j + 1])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted (Descending): " + string.Join(" ", numbers));
        Console.WriteLine("Adding this message to try revert function.");
    }
}
