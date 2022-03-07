using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterPassing
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Print()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        }
    }
}
