using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {StringLibrary.StartsWithUpper(name)}, on {date:d} at {date:t}!test");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
