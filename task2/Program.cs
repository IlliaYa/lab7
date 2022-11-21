using System;
using System.Reflection;

public interface IPerson
{
    string Name { get; set; }
    int Age { get; set; }
}
public interface IBirth
{
    string Birthday { get; set; }
}
public interface IId
{
    string Id { get; set; }
}

public class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();
        IBirth birthable = new Citizen(name, age, id, birthdate);
        IId identifiable = new Citizen(name, age, id, birthdate);
        Console.WriteLine(identifiable.Id);
        Console.WriteLine(birthable.Birthday);


    }
}