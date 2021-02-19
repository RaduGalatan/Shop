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
                        Console.WriteLine("Optiune invalida!!!!");
                         choice = Console.ReadLine()[0];
                    }
            }
        }
    }
}
