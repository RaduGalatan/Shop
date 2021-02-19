using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //shop.ShowProducts();

            while (true)
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                PremiumCustomer customer = new PremiumCustomer(name);

                Console.WriteLine("Go shopping? y/n");
                char choice = Console.ReadLine()[0];

                if (choice == 'n') break;

                if (choice == 'y')
                {
                    Menu.DisplayMenu(customer);
                }
                
            }
        }
    }
}
