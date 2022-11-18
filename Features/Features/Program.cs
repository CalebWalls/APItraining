using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Features
{
    class Program
    {

        static void Main(string[] args)
        {

            Func<int,int> func = x => x *x;
            Func<int, int, int> mult = (x, y) => x * y;
            Console.WriteLine(mult(4,5));
            Employee[] developers = new Employee[]
            {
                new Employee{Id = 1, Name = "Scott"},
                new Employee{Id = 2, Name = "Chris"}
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee{Id = 3, Name = "Alex"}
            };

            foreach(var employee in developers.Where(e => e.Name.Length == 5).OrderBy(e => e.Name))
            {
                Console.WriteLine(employee.Name);
            }

            var query2 = from developer in developers
                         where developer.Name.Length == 5 
                         orderby developer.Name descending
                         select developer;

            foreach(var developer in query2)
            {
                Console.WriteLine(developer.Name);
            }

        }








    }

  
}