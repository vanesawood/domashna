using System;
using System.IO;

class Task4
{
    static void Main()
    {
        Console.Write("Въведете път до файла: ");
        string inputPath = Console.ReadLine();

        if (!File.Exists(inputPath))
        {
            Console.WriteLine("Файлът не съществува.");
            return;
        }

        Console.Write("Въведете дума за търсене: ");
        string searchWord = Console.ReadLine();

        string outputPath = "found_lines.txt";
        using (StreamReader reader = new StreamReader(inputPath))
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(searchWord))
                {
                    writer.WriteLine(line);
                }
            }
        }

        Console.WriteLine($"Резултатите са записани в {outputPath}");
    }
}
