using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
        {
            new Person("John Smith", 22),
            new Person("Emma Johnson", 19),
            new Person("Michael Brown", 30),
            new Person("Sophia Davis", 23),
            new Person("William Wilson", 18),
            new Person("Olivia Martinez", 24),
            new Person("James Anderson", 27),
            new Person("Isabella Thomas", 21),
            new Person("Daniel Garcia", 29)
        };
            var filterPers = persons
            .Where(p => p.Age < 25)
            .OrderBy(p => p.Name.Split(' ').Last().Length)
            .ThenByDescending(p => p.Age);

            foreach (var person in filterPers)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
            Console.ReadKey();  
        }
    }
}
