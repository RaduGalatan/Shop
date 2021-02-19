using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public static class Menu
    {

        


        public static void DisplayMenu(Customer customer)
        {
            
            Console.WriteLine("1.Show Products\n2.Show Cart\n3.Leave\n4.Report");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Shop.DisplayShop(customer);
                        break;
                    }
                case 2:
                    {
                        customer.MyCart.showCart();

                        Console.WriteLine("Wanna buy? y/n");
                        if (Console.ReadLine()[0] == 'y')
                        {
                            Console.WriteLine("Do you want to pack it?(+2$) y/n");
                            if (Console.ReadLine()[0] == 'y')
                            {
                                customer.MyCart.TotalPrice += 2;
                                Report.GiftsSold++;
                            }

                            if (customer is PremiumCustomer)
                            {
                                customer.MyCart.TotalPrice = customer.MyCart.TotalPrice - customer.MyCart.TotalPrice * 0.1;

                            }
                            Shop.Buy(customer);
                            Console.WriteLine("You paid: " + customer.MyCart.TotalPrice + "$");

                            DisplayMenu(customer);
                        }
                        break;
                    }//show cart
                case 3: break;

                case 4:
                    {
                        Report.ShowReport();
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Invalid choice!");
                        break;
                    }
            }
        }
    }
}
