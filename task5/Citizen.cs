using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Citizen : Ihuman
{
    public Citizen(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }

    public int Age { get; protected set; }
    public string Id { get; protected set; }
    public string Name { get; protected set; }
}
