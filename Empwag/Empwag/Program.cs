using System;

namespace Empwag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            if (name == "praveen")
            {
                Console.WriteLine("Name is ok");
            }
            else
            {
                Console.WriteLine("Name is Not ok");
            }
        }
    }
}
