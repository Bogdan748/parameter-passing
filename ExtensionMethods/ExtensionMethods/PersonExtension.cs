using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class PersonExtension
    {
        public static void Print(this Person p)
        {
            Console.WriteLine($"Hello, my name is {p.FirstName} {p.LastName}");
        }
    }
}
