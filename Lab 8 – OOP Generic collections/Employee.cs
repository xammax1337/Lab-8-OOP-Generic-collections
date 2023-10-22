using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8___OOP_Generic_collections
{
    internal class Employee
    {
        //Properties for the Employees.
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public Employee(string id, string name, string gender, int salary)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        //Overriding to string to make it print out the correct data when using consolewriteline in Main.
        public override string ToString()
        {
            return $"{ID} - {Name} - {Gender} - {Salary}";
        }

    }
}
