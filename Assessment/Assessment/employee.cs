using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class employee
    {
        public string name;
        public string department;
        private string _designation { get; set; }
        public int salary;

        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                if (value == "Trainee")
                {
                    salary = 5000;
                    //Console.WriteLine(salary);

                }
                else if (value == "Manager")
                {
                    salary = 10000;
                    //Console.WriteLine(salary);

                }
                else if (value == "Senior Manger")
                {
                    salary = 15000;
                    //Console.WriteLine(salary);

                }
                //else
                //{
                //    Console.WriteLine("Invalid designation");
                //}
                _designation = value;
            }
        }
    }
}
