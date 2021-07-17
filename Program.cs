using System;

namespace Copilot_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci.Generate();
            Fibonacci.Generate();
        }
    }

    // Generates Fibonacci numbers using iteration.
    public static class Fibonacci
    {
        public static void Generate()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }

            Console.WriteLine("Press any key to exit...");
            Console.Read();
        }
    }

    //Generates decimals of Pi using iteration.
}