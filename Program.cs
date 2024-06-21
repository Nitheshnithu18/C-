using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5]; 
        Console.WriteLine("Enter 5 integers:");

        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            
            int temp = numbers[i];
            numbers[i] = numbers[minIndex];
            numbers[minIndex] = temp;
        }

       
        Console.WriteLine("\nSorted numbers in ascending order:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        Console.ReadLine();
    }
}
