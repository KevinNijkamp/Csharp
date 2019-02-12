using System;

namespace SoundSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Wat is uw naam?");
            name = Console.ReadLine();
            Console.WriteLine("Welkom bij SoundSharp " + name);
            login();
        }

        private static void login()
        {
            Console.WriteLine("Wat is het wachtwoord? ");

            string response = Console.ReadLine();

            if (response == "SHARPSOUND")
            {
                Console.WriteLine("Dat is het juiste wachtwoord");
            }
            else
            {
                Console.WriteLine("Dat is het onjuiste wachtwoord");
            }
            Console.ReadLine();
        }
    }
}
