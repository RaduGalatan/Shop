using System;

namespace Shop
{
    class Program
    {
     
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                Console.WriteLine("What type of customer are you?\n1. Premium customer \nAny number. Normal customer");
                Customer customer = new Customer(name);

                if(Console.ReadLine() == "1")
                {

                    customer = new PremiumCustomer(name);
                }

                

                Console.WriteLine("Go shopping? y/n");
                char choice = Console.ReadLine()[0];

                bool opt = true;
                while (opt)
                    if (choice == 'n')
                    {
                        opt = false;
                        break;
                    }
                    else if (choice == 'y')
                    {
                        opt = false;
                        Menu.DisplayMenu(customer);
                    }
                    else
                    {
                        Console.WriteLine("Invalid option!");
                        choice = Console.ReadLine()[0];
                    }
            }
        }
    }
}
