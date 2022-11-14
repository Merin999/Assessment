using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Furniture
    {
        public string Type;
        public string Wood;
        public int Price;
    }

    public void Furniture()
    {
        
    }

    public void Furniture(string type, string wood, int price)
    {
        Type = type;
        Wood = wood;
        Price = price;
    }

    public void Furniture(string type, int price)
    {

    }
}
