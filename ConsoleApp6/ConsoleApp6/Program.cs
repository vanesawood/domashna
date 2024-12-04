using System;
using System.Collections.Generic;

//1
class Program
{
    static void Main()
    {
        Console.Write("Въведете височина на триъгълника: ");
        if (!int.TryParse(Console.ReadLine(), out int height) || height < 1)
        {
            Console.WriteLine("Моля, въведете валидно цяло число за височина (по-голямо или равно на 1).");
            return;
        }

        Console.Write("Въведете посоката на ориентация (left/right): ");
        string direction = Console.ReadLine().Trim().ToLower();

        if (direction != "left" && direction != "right")
        {
            Console.WriteLine("Моля, въведете 'left' или 'right' за посоката на ориентация.");
            return;
        }

        if (direction == "right")
        {
            PrintRightOrientedTriangle(height);
        }
        else
        {
            PrintLeftOrientedTriangle(height);
        }
    }

    static void PrintRightOrientedTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            Console.Write(new string(' ', height - i));

            if (i == 1)
            {
                Console.WriteLine("*");
            }
            else if (i == height)
            {
                Console.WriteLine(new string('*', height));
            }
            else
            {
                Console.Write("*");
                Console.Write(new string(' ', i - 2));
                Console.WriteLine("*");
            }
        }
    }

    static void PrintLeftOrientedTriangle(int height)
    {
        for (int i = 1; i <= height; i++)
        {
            if (i == 1)
            {
                Console.WriteLine("*");
            }
            else if (i == height)
            {
                Console.WriteLine(new string('*', height));
            }
            else
            {
                Console.Write("*");
                Console.Write(new string(' ', i - 2));
                Console.WriteLine("*");
            }
        }
    }
}

//2

class Program1
{
    static void Main()
    {
        List<string> likes = new List<string>();

        while (true)
        {
            Console.Write("Enter a name: (Leave it empty to close the program) ");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
                break;

            likes.Add(name);
            DisplayLikeMessage(likes);
        }
    }

    static void DisplayLikeMessage(List<string> likes)
    {
        int count = likes.Count;

        if (count == 1)
        {
            Console.WriteLine($"{likes[0]} liked your post");
        }
        else if (count == 2)
        {
            Console.WriteLine($"{likes[0]} and {likes[1]} liked your post");
        }
        else if (count > 2)
        {
            Console.WriteLine($"{likes[0]}, {likes[1]} and {count - 2} others liked your post");
        }
    }
}
