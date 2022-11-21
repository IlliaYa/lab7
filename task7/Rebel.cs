using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rebel : Person, IRebel
{
    public Rebel(string name, int age, string id, string birthdate)
        : base(name, age)
    {
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Id { get; }

    public string Birthdate { get; }

    public void BuyFood()
    {
        this.Food += 10;
    }
}

