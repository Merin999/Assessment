using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class mobile
    {
        public string Name;
        public string Model;
        public int Price;
        private string Company { get; set; }

        public void ReadData()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();

            Console.Write("Model: ");
            Model = Console.ReadLine();

            Console.Write("Price: ");
            Price = int.Parse(Console.ReadLine());

            Console.Write("Company: ");
            Company = Console.ReadLine();

        }

        public void ReadData(string name, string model, int price, string company)
        {
            Name = name;
            Model = model;  
            Price = price;
            Company = company;
        }
        public void ReadData(string name, string model, int price)
        {
            Name = name;
            Model = model;
            Price = price;
            Company = "Moto";
        }
        public void ShowData()
        {
            Console.WriteLine();
            Console.WriteLine($"Name   :{Name}");
            Console.WriteLine($"Model  :{Model}");
            Console.WriteLine($"Price  :{Price}");
            Console.WriteLine($"Company:{Company}");
        }
    }
}
