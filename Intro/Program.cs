//Introduction to C#

namespace Intro
{
    using System;

    class HelloWorld
    {

        static void Main(string[] args)
        {



            //checking input argument
            if (args.Length == 0)
            
            {
                //request of name entering
                Console.WriteLine("Please, enter your name: ");

                //displaying our greetings
                Console.WriteLine($"Hello, {Console.ReadLine()}!");
                Console.ReadLine();
            }

            else

            {
                //displaying our greetings
                Console.WriteLine($"Hello, " + args[0] + "!");
                Console.ReadLine();
            }

        }

    }
}