using System;
using System.Collections.Generic;
using System.Text;

namespace TxtReader.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public string Email { get; set; }

        public Product(string name, double salary, string email)
        {
            Name = name;
            Salary = salary;
            Email = email;
        }
    }
}
