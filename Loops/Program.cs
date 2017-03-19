using System;


namespace Loops
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Choose the task:");
            string choice = Console.ReadLine();
            int ichoice = int.Parse(choice);

            switch (ichoice)
            {
                case 1:
                    ArrayFruit1();
                    break;
                case 2:
                    ArrayFruit2();
                    break;
                case 3:
                    SumN();
                    break;
                case 4:
                    FruitColor1();
                    break;
                case 5:
                    Password();
                    break;
                case 6:
                    Console.Clear();
                    NumberOutput();
                    break;
            }

            Console.ReadKey();
        }

        public static void ArrayFruit1()
        {
            string[] fruits = { "apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pinapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" };

            int count = 0;

            for (int i = 0; i < fruits.Length; i++)
            {
                if (!fruits[i].Contains("ap"))
                {
                    Console.WriteLine(fruits[i]);
                    count++;
                }
            }

            Console.WriteLine("\nThe Number of fruit which don't contain \"ap\" :" + count);
        }


        public static void ArrayFruit2()
        {
            string[] fruits = { "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pinapple", "Lime", "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry" };

            int count = 0;

            for (int i = 0; i < fruits.Length; i++)
            {
                string tFruit = fruits[i].ToLower();
                if (!tFruit.Contains("ap"))
                {
                    Console.WriteLine(tFruit);
                    count++;
                }
            }

            Console.WriteLine("\nThe Number of fruit which don't contain \"ap\": " + count);
        }


        public static void SumN()
        {
            Console.WriteLine("\n\nEnter the number to calculate the sum:");
            var enteredValue = Console.ReadLine();
            int number = Int32.Parse(enteredValue);

            int sum = 0;

            Console.WriteLine("\nThe array of number is :");
            for (int i = 1; i <= number; i++)
            {
                sum = sum + i;
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\nSum of first " + number + " numbers is: " + sum);
            Console.ReadKey();
        }

        public static void FruitColor1()

        {
            string[] colors = { "Red", "Green", "Yellow", "Blue", "Purple" };
            string[] options = { "a", "b", "c", "d", "e" };
            string answer;


            while (true)
            {
                Console.Clear();
                Console.WriteLine("What is the color of Banana?: ");
                for (int i = 0; i < colors.Length; i++)
                    Console.WriteLine(options[i] + ". " + colors[i]);
                answer = Console.ReadLine();
                if (answer != options[2])
                {
                    Console.WriteLine("Answer is wrong! Proceed? y/n: ");

                    string exit = Console.ReadLine();
                    switch (exit)
                    {
                        case "y":
                            break;
                        case "n":
                            return;
                    }

                }
                else
                {
                    Console.WriteLine("Congratulation! Banana is " + colors[2]);
                    break;
                }

            }

        }


        public static void Password()
        {
            string enteredPassword, correctPassword = "root";

            int attempts = 5;

            while (true)
            {
                //Console.Clear();
                Console.WriteLine("Enter the password: ");
                enteredPassword = Console.ReadLine();
                if (enteredPassword != correctPassword)
                {
                    attempts--;
                    Console.WriteLine("Password is not correct! You have " + attempts + " attemps.");
                }
                else
                {
                    Console.WriteLine("Congratulation! Password is correct!");
                    break;
                }
                //
                if (attempts == 0)
                {
                    Console.Clear();
                    Console.WriteLine("You have no more attempts!");
                    break;
                }
            }

        }

        public static void NumberOutput()
        {
            for (int i = 35; i <= 87; i++)
            {
                Console.WriteLine(i);
                if (i == 71)
                    break;
            }
        }

    }
}
