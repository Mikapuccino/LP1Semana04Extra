using System;

namespace testrepo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Local change, nothing will go wrong");
            SomeFunction();
        }

        private static void SomeFunction()
        {
            Console.WriteLine("Byez");
        }
    }
}
