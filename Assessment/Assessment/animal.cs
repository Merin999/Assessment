using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment;

internal class animal
{
    public string Name;
    public int MaxLifeTime;
    public string Food;
    public void ShowData()
    {
        Console.WriteLine($"Name   : {Name}");
        Console.WriteLine($"Max life time   : {MaxLifeTime}");
        Console.WriteLine($"food     :{Food}");
    }

}

