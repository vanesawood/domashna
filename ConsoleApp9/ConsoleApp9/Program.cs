using System;
using System.Collections.Generic;

class Stack
{
    private List<string> items = new List<string>();

    public void Push(string item)
    {
        items.Add(item);
    }

    public string Pop()
    {
        if (!IsEmpty())
        {
            string topItem = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return topItem;
        }
        return "Stack is empty";
    }

    public string Peek()
    {
        return !IsEmpty() ? items[items.Count - 1] : "Stack is empty";
    }

    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    public List<string> EnumerateStack()
    {
        items.Reverse();
        List<string> stackCopy = new List<string>(items);
        items.Reverse();
        return stackCopy;
    }
}

class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push("Task 1");
        stack.Push("Task 2");
        stack.Push("Task 3");

        Console.WriteLine("Peek: " + stack.Peek());
        Console.WriteLine("Popped: " + stack.Pop());
        Console.WriteLine("Stack contents: " + string.Join(", ", stack.EnumerateStack()));
    }
}
