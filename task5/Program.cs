using System;
using System.Collections.Generic;
using System.Linq;


public interface Ihuman
{
    string Id { get; }
    int Age { get; }
    string Name { get; }
}

public interface Irobot
{
    string Id { get; }
    string Model { get; }
}
   
public class Program
{
    public static void Main()
    {
        var humans = new List<Citizen>();
        string inputline = Console.ReadLine();
        while (inputline is not "End")
        {
            var info = inputline.Split();
            if (info[0] is "Human")
            {
                humans.Add(new Citizen(info[1], int.Parse(info[2]), info[3]));
            }
            inputline = Console.ReadLine();
        }
        var number = Console.ReadLine();
        var output_hum = humans.Where(x => x.Id.EndsWith(number)).Select(x => x.Id).ToList();
        Console.WriteLine(string.Join(Environment.NewLine, output_hum));

    }
}