using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pets : Ipet
{
    public Pets(string name, string Birthdate)
    {
        this.Name = name;
        this.Birthdate = Birthdate;
    }

    public string Name { get; protected set; }
    public string Birthdate { get; protected set; }
}

