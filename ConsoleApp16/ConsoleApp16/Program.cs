using System;
using System.IO;

class Task5
{
    static void Main()
    {
        Console.Write("Въведете път до CSV файла: ");
        string inputPath = Console.ReadLine();

        if (!File.Exists(inputPath))
        {
            Console.WriteLine("Файлът не съществува.");
            return;
        }

        double totalSales = 0;
        string bestSellingProduct = "";
        int maxQuantity = 0;

        using (StreamReader reader = new StreamReader(inputPath))
        {
            reader.ReadLine(); 
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                string product = parts[0];
                int quantity = int.Parse(parts[1]);
                double price = double.Parse(parts[2]);

                totalSales += quantity * price;

                if (quantity > maxQuantity)
                {
                    maxQuantity = quantity;
                    bestSellingProduct = product;
                }
            }
        }

        string outputPath = "sales_report.txt";
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            writer.WriteLine($"Обща стойност на продажбите: {totalSales:F2}");
            writer.WriteLine($"Най-продаван продукт: {bestSellingProduct}");
        }

        Console.WriteLine($"Резултатите са записани в {outputPath}");
    }
}
