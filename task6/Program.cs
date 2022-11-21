using System;
using System.Collections.Generic;
using System.Linq;


public interface Ihuman
{
    string Name { get; }
    int Age { get; }
    string Id { get; }
    string Birthdate { get; }
}

public interface Irobot
{
    string Model { get; }
    string Id { get; }
}
public interface Ipet
{
    string Name { get; }
    string Birthdate { get; }
}

public class Program
{
    public static void Main()
    {
        var humans = new List<Citizen>();
        var pets = new List< Pets>();
        string inputline = Console.ReadLine();
        while (inputline is not "End")
        {
            var info = inputline.Split();
            if (info[0] is "Human")
            {
                humans.Add(new Citizen(info[1], int.Parse(info[2]), info[3], info[4]));
            }
            else if (info[0] is "Pet")
            {
                pets.Add(new Pets(info[1], info[2]));
            }
            inputline = Console.ReadLine();
        }
        var year = Console.ReadLine();
        var dates = humans
            .Where(x => x.Birthdate.EndsWith(year))
            .Select(x => x.Birthdate)
            .ToList()
            .Concat(pets.Where(x => x.Birthdate.EndsWith(year))
            .Select(x => x.Birthdate)
            .ToList());
        Console.WriteLine(string.Join(Environment.NewLine, dates));

    }
}