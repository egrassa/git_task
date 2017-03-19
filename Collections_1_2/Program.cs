using System;


namespace Collections_1_2
{
    class Program
    {
        static void Main()
        {
            //Array initialization

            int index;
            while (true)
            {
                Console.WriteLine("Enter number of elements in array: ");
                string input = Console.ReadLine();

                //try to parse string to int32
                bool inputStringFlag = Int32.TryParse(input, out index);

                if (!inputStringFlag || index <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Entered value is not correct! Try again! string");

                }
                else
                {
                    break;
                }
            }

            
            Console.WriteLine("Enter number of start elements in array: ");
            int startN = Num(index);
            Console.WriteLine("Enter number of end elements in array: ");
            int endN = Num(index );

            int[] myArray = new int[index];

            Random rnd = new Random();
            Console.WriteLine("\n");
            for (int i = 0; i < index; i++)
            {
                myArray[i] = rnd.Next(100);
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("\n\nFirst " + startN + " elements of array: ");
            for (int i = 0; i < startN; i++)
            {

                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("\n\nLast " + endN + " elements of array: ");
            Array.Reverse(myArray);

            for (int i = 0; i < endN; i++)
            {

                Console.WriteLine(myArray[i]);
            }


            Console.ReadKey();
        }

        public static int Num(int idx)
        {
            int n;
            while (true)
            {
                string input1 = Console.ReadLine();
                bool inputStringFlag1 = Int32.TryParse(input1, out n);

                if (!inputStringFlag1 || (n < 0 || n > idx))
                {
                    Console.Clear();
                    Console.WriteLine("Entered value is not correct! Try again!");
                    continue;
                }
                  break;
            }
            return n;
        }

    }
}
