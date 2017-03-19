using System;
using System.Runtime.CompilerServices;

namespace Conditions
{
    class Program
    {

        static void Main()
        {
            Console.Title = "My Application. Conditions.";


            while (true)
            {

                int enteredNumber;

                bool Flag = KeyboardInput(out enteredNumber);
                //
                if (!Flag)
                {
                    Console.Clear();
                    Console.WriteLine("Entered value is not an integer number! Try again!");
                    continue;
                }
                //

                if (enteredNumber < 0 || enteredNumber > 100)
                {
                    Console.Clear();
                    Console.WriteLine("Warning! Entered number is not in the allowable range. Try again!");
                    continue;
                }

                Console.Clear();
                Console.WriteLine("Congratulation! Your number is " + enteredNumber);

                //parity definition

                Console.WriteLine(((enteredNumber % 2).Equals(0)) ? "This number is even." : "This number is odd.");

                //Magic numbers  - 13, 22, 67

                switch (enteredNumber)
                {
                    case 13:
                    case 22:
                    case 67:
                        Console.WriteLine("The number " + enteredNumber + " is magic!");
                        break;
                }

                //Console.WriteLine("To check number again enter 'y', to exit 'exit': ");

                //exit or proceed
                Console.WriteLine("Exit? y/n : ");
                string choice = Console.ReadLine();

                if (choice == "y")
                    break;
                if (choice == "n")
                    continue;
                
            }//end of major loop

        }//end of Main method



        public static bool KeyboardInput(out int enteredNumber)
        {
            Console.WriteLine("Enter your number:");
            string inputString = Console.ReadLine();

            //try to parse string to int32
            bool inputStringFlag = Int32.TryParse(inputString, out enteredNumber);

            return inputStringFlag;
        }

    }//end of class Program

}//end of namespace conditions








