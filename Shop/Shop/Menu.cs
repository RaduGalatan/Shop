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
            int choice = 0;
            bool option = true;
            while (option)
            {
                try{
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 1 || choice > 4)
                    {
                        Console.WriteLine("Optiune invalida, tastati din nou: ");

                    }
                    else
                    {
                        option = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Optiune invalida, tastati din nou: ");
                }
                
            }
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
                        if (customer.MyCart.ProductList.Count != 0)
                        {
                            Shop.WannaBuy(customer);
                        }
                        else
                        {
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
