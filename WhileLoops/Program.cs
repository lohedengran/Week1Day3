using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i++);
            }

            Console.ReadKey();

            Console.WriteLine("Enter a number between 1 and 100:");
            int input = int.Parse(Console.ReadLine());
            while (input <= 100 && input >= 1)
            {
                Console.WriteLine(input++);
            }

            int j = 1;

            Console.ReadKey();

            do
            {
                Console.WriteLine(j++);
            } while (j <=20);

            Console.ReadKey();

            Console.WriteLine("Enter a number between 1 and 100:");
            int secondInput = int.Parse(Console.ReadLine());
            if (secondInput >= 1 && secondInput <= 100)
            {
                do
                {
                    Console.WriteLine(secondInput++);
                } while (secondInput <= 100);
            }


        }
    }
}
