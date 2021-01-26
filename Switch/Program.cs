using System;

namespace Switch
{
    class Program
    {


        static void VisaMeny()
        {
            Console.WriteLine("Gör ett val av alternativen nedan");
            Console.WriteLine("Tryck I för insättning");
            Console.WriteLine("Tryck U för uttag");
            Console.WriteLine("Tryck S för saldo");
            Console.WriteLine("Tryck A för avsluta");
        }
        static void Main(string[] args)
        {
            int saldo = 0;
            bool done = false;


            while (!done)
            {
                VisaMeny();
                var menyVal = Console.ReadKey(true);

                switch (menyVal.Key)
                {
                    case ConsoleKey.I:
                        Console.WriteLine("Du har valt insättning.");
                        saldo = GörInsättning(saldo);
                        break;
                    case ConsoleKey.U:
                        Console.WriteLine("Du har valt uttag.");
                        saldo = GörUttag(saldo);
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("Du har valt saldo.");
                        VisaSaldo(saldo);
                        break;
                    case ConsoleKey.A:
                        Console.WriteLine("Du har valt att avsluta.");
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Du angav ett felaktivt värde.");
                        break;
                }

            }

        }


        private static void VisaSaldo(int saldo)
        {
            Console.Clear();
            Console.WriteLine($"Ditt saldo är {saldo} kr.");
        }


        private static int GörInsättning(int nuvarandeSaldo)
        {
            Console.Clear();
            Console.WriteLine("Ange summa för insättning: ");
            int summaFörInsättning = int.Parse(Console.ReadLine());
            if (summaFörInsättning > 0)
            {
                Console.WriteLine($"Summa att sätta in: {summaFörInsättning} kr.");
                nuvarandeSaldo += summaFörInsättning;
            }
            else
            {
                Console.WriteLine("Ange en summa större än 0.");
            }
            return nuvarandeSaldo;
        }
        private static int GörUttag(int nuvarandeSaldo)
        {
            Console.Clear();
            Console.WriteLine("Ange summa för uttag: ");
            int summaFörUttag = int.Parse(Console.ReadLine());
            if(summaFörUttag <= nuvarandeSaldo)
            {
                Console.WriteLine($"Du har tagit ut {summaFörUttag} kr.");
                nuvarandeSaldo -= summaFörUttag;
            } else 
            {
                Console.WriteLine("Otillräckligt saldo på kontot");
            }
            return nuvarandeSaldo;
        }
    }
}
