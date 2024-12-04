using System;
using System.Collections.Generic;

class Solution
{
    public int MaxPairs(int K, int[] C, int[] D)
    {
        var cleanMap = new Dictionary<int, int>();
        var dirtyMap = new Dictionary<int, int>();

        foreach (int sock in C)
            cleanMap[sock] = cleanMap.GetValueOrDefault(sock, 0) + 1;

        foreach (int sock in D)
            dirtyMap[sock] = dirtyMap.GetValueOrDefault(sock, 0) + 1;

        int pairs = 0;

        foreach (var kvp in cleanMap)
        {
            pairs += kvp.Value / 2;
            cleanMap[kvp.Key] = kvp.Value % 2;
        }

        foreach (var kvp in cleanMap)
        {
            if (K > 0 && kvp.Value == 1 && dirtyMap.GetValueOrDefault(kvp.Key, 0) > 0)
            {
                pairs++;
                K--;
                dirtyMap[kvp.Key]--;
            }
        }

        foreach (var kvp in dirtyMap)
        {
            while (K > 1 && kvp.Value >= 2)
            {
                pairs++;
                K -= 2;
                dirtyMap[kvp.Key] -= 2;
            }
        }

        return pairs;
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();
        int K = 2;
        int[] C = { 1, 2, 1, 1 };
        int[] D = { 1, 4, 3, 2, 4 };

        int result = solution.MaxPairs(K, C, D);
        Console.WriteLine(result); 
    }
}
