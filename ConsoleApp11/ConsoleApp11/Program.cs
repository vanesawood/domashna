using System;

class Solution
{
    public bool CanLevelUp(int experience, int threshold, int reward)
    {
        return experience + reward >= threshold;
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine(solution.CanLevelUp(10, 15, 5)); 
        Console.WriteLine(solution.CanLevelUp(10, 15, 4)); 
    }
}
