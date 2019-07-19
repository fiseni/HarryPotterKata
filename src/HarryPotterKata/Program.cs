using System;

namespace HarryPotterKata
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Harro Potter Kata !!!");

            do
            {
                UserInput.Process();
                Console.Write("Please enter 'q' key to quit, or any key to continue for another round : ");

            } while (!"q".Equals(Console.ReadLine(), StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
