using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment;

internal class Parent
{
    public string FamilyName { get; set; }
}
class Child : Parent
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }

    public void ShowData()
    {
        Console.WriteLine($"Name   :  {Name}");
        Console.WriteLine($"FamilyName   :  {FamilyName}");
        Console.WriteLine($"Age         : {Age}");
        Console.WriteLine($"Occupation  : {Occupation}");
    }
}
