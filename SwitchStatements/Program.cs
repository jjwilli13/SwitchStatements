using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            var response = Console.ReadLine();

            switch (response)
            {
                case "Math":
                    Console.WriteLine("That's cool. Im not very good at Math though.");
                    break;
                case "English":
                    Console.WriteLine("English? I prefer German.");
                    break;
                case "History":
                    Console.WriteLine("Nice, but can you recite the presidents in order?");
                    break;
                case "Science":
                    Console.WriteLine("Awesome, I always liked science experiments.");
                    break;
                case "Physical Ed":
                    Console.WriteLine("Now that's what I'm talking about!");
                    break;
                default:
                    Console.WriteLine("Never heard of that one......");
                    break;
            }
        }
    }
}

