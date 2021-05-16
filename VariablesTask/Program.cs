using System;

namespace VariablesTask
{
    class Program
    {
        static void Main(string[] args) {
            string word_1;
            string word_2;

            word_1 = "10";
            word_2 = "20";

            int num_1;
            int num_2; 

            //these two lines convert word_1 and word_2 into ints and assign to num_1 and num_2 respectively
            num_1 = int.Parse(word_1);
            num_2 = int.Parse(word_2);

            Console.WriteLine(num_1 + num_2);

         }
    }
}
