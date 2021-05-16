using System;

namespace VariablesTask
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Enter name");

            string Name = Console.ReadLine();

            Console.WriteLine("First name is " + Name);

            Console.WriteLine("Enter surname");
            
            string Lastname = Console.ReadLine();

            Console.WriteLine("Last name is " + Lastname);

            Console.WriteLine("Enter StudentID");

            int ID = 103564240;

            Console.WriteLine(Name + "'s StudentID is " + ID);

            
         }
    }
}
