using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreetLibrary;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetingProgram greetingProgram = new GreetingProgram();
            greetingProgram.OnGreet += (name) =>
            {
                Console.WriteLine($"Hello , {name} Nice to meet you");
            };
             Console.WriteLine("Welcome to the greeting program");

            greetingProgram.GetUserInput();

            Console.ReadLine();

        }
    }
}
