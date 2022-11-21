using System;
using System.Reflection;

public interface IPerson
{
    string Name { get; set; }
    int Age { get; set; }
}
public class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        IPerson person = new Citizen(name, age);
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);

    }
}
