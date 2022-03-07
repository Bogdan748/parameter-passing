using System;

namespace ParameterPassing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i= 10;
            Console.WriteLine($"Before clling Increment :{i}");
            Increment( ref i);
            Console.WriteLine($"After clling Increment :{i}");
            */


            Person p = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Console.WriteLine($"Defore change: ");
            p.Print();
            ChangeName(ref p);
            Console.WriteLine($"After change: ");
            p.Print();
            
            
        }

        private static void Increment ( int i, out int j)
        {
            Console.WriteLine($"Before increase: {i}");
            i = i + 1;
            Console.WriteLine($"After increase: {i}");
            j = 10;
        }

        private static void ChangeName(ref Person p)
        {
            Console.Write($"Before change  ");
            p.Print();
            //p.FirstName = "Dorel";

            p = new Person
            {
                FirstName = "Dany",
                LastName = "Void"
            };


            Console.Write($"After change  ");
            p.Print();
        }
    }
}
