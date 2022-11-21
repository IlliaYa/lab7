using System;
using System.Collections.Generic;
using System.Linq;
public interface IBuyer
{
    void BuyFood();
    int Food { get; }
}
public interface IPerson : IBuyer
{
    string Name { get; }
    int Age { get; }
}

public interface ICitizen : IPerson
{
    string Group { get; }
}
public interface IRebel : IPerson
{
    string Id { get; }
    string Birthdate { get; }
}

public class Program
{
    public static void Main()
    {
        IList<IPerson> people = new List<IPerson>();

        var Lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < Lines; i++)
        {
            var inputLine = Console.ReadLine();
            people.Add(CreatePerson(inputLine));
        }

        var name = Console.ReadLine();
        while (name is not ("End"))
        {
            AddFood(name, people);
            name = Console.ReadLine();
        }
        Console.WriteLine(people.Sum(x => x.Food));
    }

    private static void AddFood(string name, IList<IPerson> people)
    {
        if (people.Any(p => p.Name == name))
        {
            people.First(x => x.Name == name).BuyFood();
        }
    }

    private static IPerson CreatePerson(string inputLine)
    {
        var tokens = inputLine.Split();

        if (tokens.Length == 3)
        {
            return new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
        }
        return new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
    }

}
