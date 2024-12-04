using System;
using System.IO;

class Task6
{
    static long Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    static void Log(string logFilePath, int input, long result)
    {
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: Input = {input}, Result = {result}");
        }
    }

    static void Main()
    {
        string logFilePath = "log.txt";

        while (true)
        {
            Console.Write("Въведете число за факториел (или 'exit' за изход): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number))
            {
                long result = Factorial(number);
                Console.WriteLine($"Факториел на {number} = {result}");
                Log(logFilePath, number, result);
            }
            else
            {
                Console.WriteLine("Невалидно число.");
            }
        }

        Console.WriteLine($"Лог файлът е записан в {logFilePath}");
    }
}
