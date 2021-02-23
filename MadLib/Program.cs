using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please fill in your answer");

            Console.WriteLine("name a color.");
            var color = Console.ReadLine();


            Console.WriteLine($"favorite ethnic food.");
            var food = Console.ReadLine();


            Console.WriteLine($"a country");
            var country = Console.ReadLine();

            Console.WriteLine($"a verb");
            var verb = Console.ReadLine();

            Console.WriteLine($"a sport");
            var sport = Console.ReadLine();

            Console.WriteLine($"pizza topping");
            var pizza = Console.ReadLine();

            Console.WriteLine($"_-----------------------");

            Console.WriteLine($"Once upon a time a young person who loved {color} computers thought that he would enroll in a TrueCoders course. His goal was to create a program called {food} that would help farmers who {verb} {sport} in {country} and raised {pizza}.");
        }
    }
}
