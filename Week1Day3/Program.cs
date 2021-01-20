using System;

namespace Week1Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en nämnare: ");
            string keyboardInput = Console.ReadLine();
            int nämnare = 0;

            try
            {
                nämnare = int.Parse(keyboardInput);

                if (nämnare != 0)
                {
                    int kvot = 20 / nämnare;
                    Console.WriteLine($"{20} / {nämnare} = {kvot}");
                }
                else
                    Console.WriteLine("Du kan inte dividera talet med 0");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Strängen har värdet null och kan inte konverteras.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Felaktig inmatning");

            }
            catch (OverflowException)
            {
                Console.WriteLine($"Talet måste vara ett tal mellan {int.MinValue} och {int.MaxValue}");
            }
            catch (Exception)
            {
                Console.WriteLine("Felaktiv inmatning!"); ;
            }
            finally
            {
                Console.WriteLine("Denna kodrad kommer ALLTID att köra oavsett om vi får ett exception eller inte.");
            }



            Console.WriteLine("Nu fortsätter programmet att köra!");
        }
    }
}
