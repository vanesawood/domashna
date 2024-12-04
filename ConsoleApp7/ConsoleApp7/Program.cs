using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the train (meters): ");
        int trainLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the speed of the train (m/sec): ");
        int speed = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the time to pass the bridge (seconds): ");
        int time = int.Parse(Console.ReadLine());

        int bridgeLength = (speed * time) - trainLength;
        Console.WriteLine("Length of the bridge: " + bridgeLength + " meters");
    }
}
