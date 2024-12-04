using System;

class Program
{
    static int CalculateAppleDifference(int k)
    {
        int yellowApples = 0;
        int redApples = 0;

        for (int i = 1; i <= k; i++)
        {
            int applesInBox = i * i;
            if (i % 2 == 0)
                redApples += applesInBox;
            else
                yellowApples += applesInBox;
        }

        return redApples - yellowApples;
    }

    static void Main()
    {
        Console.WriteLine("Enter the number of apple boxes (k): ");
        int k = int.Parse(Console.ReadLine());

        int result = CalculateAppleDifference(k);
        Console.WriteLine("Difference between red and yellow apples: " + result);
    }
}
