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
            
            Console.Write("Please enter your age: ");
            
            int ageNum = int.Parse(age);

            if (ageNum >= 17) {
                Console.WriteLine(gender + "is an adult");

            } else {
                Console.WriteLine(gender + "is not an adult");
            }
            }
            
        }
    }

