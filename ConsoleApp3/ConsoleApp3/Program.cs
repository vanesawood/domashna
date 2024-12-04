using System;
//1
class ChessboardGrains
{
    static void Main()
    {
        int squares = 64;
        ulong totalGrains = 0;

        for (int i = 1; i <= squares; i++)
        {
            ulong grainsOnSquare = (ulong)Math.Pow(2, i - 1);
            totalGrains += grainsOnSquare;
            Console.WriteLine($"Square {i}: {grainsOnSquare} grains");
        }

        Console.WriteLine($"\nTotal number of grains on the chessboard: {totalGrains}");
    }
}
//2

class DnaToRnaTranscription
{
    public static string ToRna(string dna)
    {
        char[] rna = new char[dna.Length];

        for (int i = 0; i < dna.Length; i++)
        {
            rna[i] = dna[i] switch
            {
                'G' => 'C',
                'C' => 'G',
                'T' => 'A',
                'A' => 'U',
                _ => throw new ArgumentException("Invalid nucleotide in DNA sequence"),
            };
        }

        return new string(rna);
    }

    public static void Main()
    {
        string dna = "GCTA";
        string rna = ToRna(dna);
        Console.WriteLine($"RNA Complement: {rna}");
    }
}
//3

class SpeedCalculator
{
    public static double GetMetersPerSecond(double distance, int hours, int minutes, int seconds)
    {
        double timeInSeconds = hours * 3600 + minutes * 60 + seconds;
        return distance / timeInSeconds;
    }

    public static double GetKilometersPerHour(double distance, int hours, int minutes, int seconds)
    {
        double timeInSeconds = hours * 3600 + minutes * 60 + seconds;
        double timeInHours = timeInSeconds / 3600;
        return (distance / 1000) / timeInHours;
    }

    public static double GetMilesPerHour(double distance, int hours, int minutes, int seconds)
    {
        double timeInSeconds = hours * 3600 + minutes * 60 + seconds;
        double timeInHours = timeInSeconds / 3600;
        return (distance / 1609) / timeInHours;
    }

    public static void Main()
    {
        Console.Write("Enter distance in meters: ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time - Hours: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Minutes: ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        double speedMps = GetMetersPerSecond(distance, hours, minutes, seconds);
        double speedKph = GetKilometersPerHour(distance, hours, minutes, seconds);
        double speedMph = GetMilesPerHour(distance, hours, minutes, seconds);

        Console.WriteLine($"\nSpeed:");
        Console.WriteLine($"Meters per second: {speedMps:F2}");
        Console.WriteLine($"Kilometers per hour: {speedKph:F2}");
        Console.WriteLine($"Miles per hour: {speedMph:F5}");
    }
}

//4

class Triangle
{
    public static void Main()
    {
        Console.Write("Enter the length of side a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (a <= 0 || b <= 0 || c <= 0 || a + b < c || a + c < b || b + c < a)
        {
            Console.WriteLine("The sides do not form a valid triangle.");
        }
        else if (a == b && b == c)
        {
            Console.WriteLine("The triangle is equilateral.");
        }
        else if (a == b || b == c || a == c)
        {
            if (a + b == c || a + c == b || b + c == a)
                Console.WriteLine("The triangle is degenerate.");
            else
                Console.WriteLine("The triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is scalene.");
        }
    }
}

//5

class StringReverser
{
    public static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static void Main()
    {
        Console.Write("Enter a string to reverse: ");
        string input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            string reversed = ReverseString(input);
            Console.WriteLine($"Reversed string: {reversed}");
        }
        else
        {
            Console.WriteLine("Input cannot be empty.");
        }
    }
}
