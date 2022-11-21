using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string id, string firstName, string lastName, double salary, string crops)
        : base(id, firstName, lastName, salary, crops)
    {
        this.Repairs = new List<IRepair>();
    }

    public IList<IRepair> Repairs { get; }

    public override string ToString()
    {
        return $"{base.ToString()}Repairs:{Environment.NewLine + "  "}{string.Join(Environment.NewLine + "  ", this.Repairs)}";
    }
}
