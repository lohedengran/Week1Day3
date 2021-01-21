using System;

namespace Switch
{
    class Program
    {

        private static void VisaMeny()
        {
            Console.WriteLine("Gör ett val av alternativen nedan");
            Console.WriteLine("Tryck I för instättning");
            Console.WriteLine("Tryck U för uttag");
            Console.WriteLine("Tryck S för saldo");
            Console.WriteLine("Tryck A för avsluta");
        }
        static void Main(string[] args)
        {
            VisaMeny();

            var menyVal = Console.ReadKey(true); 
            bool done = false;
            
            while (!done)
            {
                switch (menyVal.Key)
                {
                    case ConsoleKey.I:
                        Console.WriteLine("Du har valt insättning");
                        break;
                    case ConsoleKey.U:
                        Console.WriteLine("Du har valt uttag");
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Du har valt saldo");
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Du har valt att avsluta");
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Du angav ett felaktivt värde");
                        break;
                }
                done = true;
                
               
            }


            

        }
    }
}
