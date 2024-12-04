using System;
using System.IO;

class Task1
{
    static void Main()
    {
        Console.Write("Въведете път до текстовия файл: ");
        string inputPath = Console.ReadLine();

        if (!File.Exists(inputPath))
        {
            Console.WriteLine("Файлът не съществува.");
            return;
        }

        string[] lines = File.ReadAllLines(inputPath);
        string text = File.ReadAllText(inputPath);

        int wordCount = text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
        int sentenceCount = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

        string outputPath = "result.txt";
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            writer.WriteLine($"Брой на думите: {wordCount}");
            writer.WriteLine($"Брой на изреченията: {sentenceCount}");
            writer.WriteLine("Първите 3 реда:");
            for (int i = 0; i < Math.Min(3, lines.Length); i++)
            {
                writer.WriteLine(lines[i]);
            }
        }

        Console.WriteLine($"Резултатите са записани в {outputPath}");
    }
}
