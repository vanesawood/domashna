internal static class SolutionHelpers
{
    private static void Main(string[] args)
    {
        int x = 10;
        int y = 85;
        int d = 30;

        int distanceToCover = y - x;

        int jumpsNeeded = distanceToCover / d;
        if (distanceToCover % d != 0)
        {
            jumpsNeeded += 1;
        }

        Console.WriteLine(jumpsNeeded);
    }
}