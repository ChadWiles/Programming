using System;

namespace SelectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            string age = Console.ReadLine();

            int ageNum = int.Parse(age);

            if (ageNum >= 17) {
                Console.WriteLine("Legally adult age");

            } else
                {
                    Console.WriteLine("Legally not adult age");
                }
 
            Console.Write("Please enter your gender: ");
            string gender = Console.ReadLine();

            if (ageNum >= 17) {
                Console.WriteLine(gender + " is an adult");

            } else {
                Console.WriteLine(gender + " is not an adult");
            }
            
            Console.Write("Please enter a number: ");

            int num_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a second number: ");

            int num_2 = Convert.ToInt32(Console.ReadLine());

            if (num_1 + num_2 >= 10) {
                Console.WriteLine("Sum is greater than 10");
            
            if (num_1 + num_2 == 10) {
                Console.WriteLine("The total amount equals 10! You did it!");
            }

            } else {
                Console.WriteLine("Sum of numbers is less than 10");
            }

            
        }
    }
}






