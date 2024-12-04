using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Email: {Email}";
    }
}

class Task3
{
    static void Main()
    {
        string filePath = "people.bin";

        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25, Email = "alice@example.com" },
            new Person { Name = "Bob", Age = 30, Email = "bob@example.com" },
            new Person { Name = "Charlie", Age = 35, Email = "charlie@example.com" }
        };

        SaveToFile(filePath, people);
        List<Person> loadedPeople = LoadFromFile(filePath);
        Console.WriteLine("Прочетени обекти:");
        foreach (var person in loadedPeople)
        {
            Console.WriteLine(person);
        }
    }

    static void SaveToFile(string filePath, List<Person> people)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, people);
        }
    }

    static List<Person> LoadFromFile(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return (List<Person>)formatter.Deserialize(fs);
        }
    }
}
