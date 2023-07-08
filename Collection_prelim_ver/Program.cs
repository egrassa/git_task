using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collection_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //hard-coded base simulation
            List<string> stuff = new List<string>() { "notebook", "tablet", "smart-phone", "cellphone", "dect-phone", "smart bracelet", "hands-free", "3G modem", "4G modem" };
            Dictionary<string, List<string>> HistoryCart = new Dictionary<string, List<string>>()
            {{"John", new List<string>{"notebook", "tablet", "smart-phone", "cellphone", "tablet"}},{"Marry", new List<string>{"cellphone", "tablet", "smart-phone"}},{"Rich", new List<string>{"dect-phone", "hands-free"}}};

            //Initialization current user and cart for shopping
            string currentUser = "";
            List<string> currentCart = new List<string>();


            //Start action block
            switch (StartAction())
            {
                case 1:
                    HistoryCart = UserRegister(HistoryCart);
                    currentUser = HistoryCart.Keys.Last();
                    break;
                case 2:
                    currentUser = Login(HistoryCart);
                    break;
            }
            //Display bought goods for current session
            currentCart = Shopping(currentUser, stuff);
            Console.Clear();
            Console.WriteLine("Buyer - " + currentUser + "\nBought goods: ");


            foreach (var items in currentCart)
            {
                Console.WriteLine("* " + items);
            }

            //Update history cart for current user
            HistoryCart[currentUser].AddRange(currentCart);
            
            //Display historical cart for current user

            Console.WriteLine($"\n\n{currentUser}'s list bought goods: ");
            foreach (var v in HistoryCart[currentUser])
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("To exit the store press any key! ");
            Console.ReadLine();
        }
        
        
        //register(adding to the dictionary) new buyer in the system
        public static Dictionary <string, List<string>> UserRegister(Dictionary<string, List<string>> a)
        {
            Console.WriteLine("Enter new buyer name: ");
            string user = Console.ReadLine();
            a[user] = new List<string>() {""};
            return a;
        }

        //login existing buyer(checking that entered user exist in dictionary
        public static string Login(Dictionary<string, List<string>> a)
        {
            while (true)
            {
                Console.WriteLine("Enter registered buyer name (case sensitive):");
                string enteredUser = Console.ReadLine();

                foreach (var kvpair in a)
                    if (kvpair.Key == enteredUser)
                    {
                        string currentUser = enteredUser;
                        return currentUser;
                    }
                Console.Clear();
                Console.WriteLine("No match. Try again? y/n");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "y":
                        break;
                    case "n":
                        Environment.Exit(0);
                        break;
                }
            }
           //return "0";
        }

        public static int StartAction()
        {
            while (true)
            {
                Console.WriteLine("Add new buyer(1)/Login existig buyer(2):");
                string inputString = Console.ReadLine();
                int action;
                //try to parse string to int32
                bool inputStringFlag = Int32.TryParse(inputString, out action);

                if (!inputStringFlag)
                {
                    Console.Clear();
                    Console.WriteLine("Entered option is not correct! Try again! string");
                    continue;
                }
                if (!(action == 1 || action == 2))
                {
                    Console.Clear();
                    Console.WriteLine("Entered option is not correct! Try again! nother 1 or 2");
                    continue;
                }
                return action;
            }
        }


        public static List<string> Shopping(string user, List<string> stuff)
        {
            List<string> c_cart= new List<string>();
            int i = 1;

            while (true)
            {
                
                Console.Clear();
                Console.WriteLine("\nChoose stuff to buy: ");

                foreach (var item in stuff)
                {
                    Console.WriteLine((i++) + ". " + item);
                }
                Console.WriteLine("\n:");
                string s_index = Console.ReadLine();
                int stuff_index = Int32.Parse(s_index);
                if (stuff_index < 1 || stuff_index > i)
                    continue;
                c_cart.Add(stuff.ElementAt(stuff_index-1));

                Console.WriteLine("\nShopping cart: ");

                //int j = 1;
                c_cart.ForEach(c => Console.WriteLine((c_cart.IndexOf(c)+1) + ". " + c));

                //foreach (var it in c_cart)
                //    Console.WriteLine((j++) + ". " + it);

                Console.WriteLine("Proceed shopping? y/n");
                string ch = Console.ReadLine();
                if(ch == "n")
                    return c_cart;
            }
        }
        /*
        bool ReadUserInput()
        {

        }
        */
    }
}
