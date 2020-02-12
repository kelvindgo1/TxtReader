using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using TxtReader.Entities;

namespace TxtReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',',',');
                    string name = fields[0];                    
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, salary, email));
                }
            }

            Console.WriteLine("Enter salary: ");
            double ns = double.Parse(Console.ReadLine());            
            Console.WriteLine("Email of people whose salary is more than "+ ns+ ":");
            var lst = list.Where(m => m.Salary > ns).OrderByDescending(m => m.Email).Select(m => m.Email);
            foreach(string x in lst)
            {
                Console.WriteLine(x);
            }
            var sum = list.Where(x => x.Name[0] == 'M').Sum(x => x.Salary);

            Console.WriteLine("Sum of Salaryof people whose name starts with 'M':" +sum);
            


        }
    }
}
