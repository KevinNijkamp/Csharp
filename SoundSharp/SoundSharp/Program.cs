using System;

namespace SoundSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, input;
            Console.WriteLine("Wat is uw naam?");
            name = Console.ReadLine();
            input = Console.ReadLine();
            Console.WriteLine("Welkom bij SoundSharp " + name);
            Console.ReadLine();
        }
    }
}
