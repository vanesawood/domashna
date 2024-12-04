using System;
using System.Collections.Generic;
//1
class Solution
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

//2
class Program
{
    private static void Main(string[] args)
    {
        int nCols = 16;
        int nRows = 11;
        int col = 5;
        int row = 3;
        int result = SeatsInTheater(nCols, nRows, col, row);
        Console.WriteLine("Number of people who will be disturbed: " + result);
    }

    static int SeatsInTheater(int nCols, int nRows, int col, int row)
    {
         return (nRows - row) * (nCols - col + 1);
    }
}

//3

class Door
{
    private int number;

    public Door(int number)
    {
        this.number = number;
    }

    public List<string> Draw()
    {
        List<string> door = new List<string>
        {
            "  ------------  ",
            " |            | ",
            " |------------| ",
            $" |    Door {number}   | ",
            " |            | ", 
            " <>-----------| ", 
            " |            | ", 
            " |            | ", 
            "  ------------  " 
        };
        return door;
    }
}

class DoorWall
{
    private List<Door> doors;

    public DoorWall(int doorCount)
    {
        doors = new List<Door>();
        for (int i = 1; i <= doorCount; i++)
        {
            doors.Add(new Door(i));
        }
    }

    public void DrawWall()
    {
        for (int row = 0; row < 8; row++)  
        {
            foreach (Door door in doors)
            {
                Console.Write(door.Draw()[row] + "   ");
            }
            Console.WriteLine();
        }
    }
}

class Prog
{
    static void Main()
    {
        DoorWall wall = new DoorWall(3);
        wall.DrawWall();
    }
}
