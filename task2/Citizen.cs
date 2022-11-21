using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Citizen : IPerson, IBirth, IId
{
    public Citizen(string name, int age, string birthday, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Birthday = birthday;
        this.Id = id;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public string Birthday { get; set; }
    public string Id { get; set; }

}
