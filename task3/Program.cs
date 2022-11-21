using System;
public interface ICar
{
    string Model { get; }
    string Brakes { get; }
    string GasPedal { get; }
    string DriversName { get; }
}
public class Program
{
    public static void Main()
    {
        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("error");
        }

        var driverName = Console.ReadLine();
        ICar car = new Ferrari(driverName);
        Console.WriteLine(car);

    }
}