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

            string ID = Console.ReadLine();

            Console.WriteLine(Name + "'s StudentID is " + ID);



            Console.WriteLine("Enter Year of Birth");

            string YOB = Console.ReadLine();

            Console.WriteLine(Name + "'s Year of Birth is " + YOB);



            Console.WriteLine("What year is it?");

            string Year = Console.ReadLine();

            Console.WriteLine("The year is " + Year);            

            
         }
    }
}
