using System;
using System.IO;

class Task2
{
    static void Main()
    {
        Console.Write("Въведете път до изходния файл: ");
        string sourcePath = Console.ReadLine();

        if (!File.Exists(sourcePath))
        {
            Console.WriteLine("Изходният файл не съществува.");
            return;
        }

        Console.Write("Въведете път до целевия файл: ");
        string destinationPath = Console.ReadLine();

        using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open))
        using (FileStream destinationStream = new FileStream(destinationPath, FileMode.Create))
        {
            sourceStream.CopyTo(destinationStream);
        }

        Console.WriteLine("Файлът беше копиран успешно.");
    }
}
