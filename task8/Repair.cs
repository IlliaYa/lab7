﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Repair : IRepair
{
    public Repair(string partName, int hoursWorked)
    {
        this.PartName = partName;
        this.HoursWorked = hoursWorked;
    }

    public string PartName { get; protected set; }
    public int HoursWorked { get; protected set; }

    public override string ToString()
    {
        return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
    }
}
