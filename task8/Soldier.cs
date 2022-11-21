using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Soldier : ISoldier
{
    protected Soldier(string id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string Id { get; protected set; }

    public string FirstName { get; protected set; }

    public string LastName { get; protected set; }
}
