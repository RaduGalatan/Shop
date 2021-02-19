using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public static class Shop
    {
        public static Dictionary<Product, int> Products { get; set; }
        static Product books = new Product(ProductsType.Books);
        static Product flowers = new Product(ProductsType.Flowers);
        static Product chocolate = new Product(ProductsType.Chocolate);
        static Shop()
        {
           
            Products = new Dictionary<Product, int>() {
                {
                    books,10
                },
                {
                    flowers,15
                },
                {
                    chocolate,50
                }
            };
           
            
        }

        public static void WannaBuy(Customer customer)
        {
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

                Menu.DisplayMenu(customer);
            }
        }

        public static void Buy(Customer customer) 
        {

            foreach (var product in customer.MyCart.ProductList)
            {
                
                if (product.Key.Name.Equals(ProductsType.Books))
                {
                    Products[books] -= product.Value;
                    Report.BooksSold += product.Value;
                }
                if (product.Key.Name.Equals(ProductsType.Flowers))
                {
                    Products[flowers] -= product.Value;
                    Report.FlowersSold += product.Value;
                }
                if (product.Key.Name.Equals(ProductsType.Chocolate))
                {
                    Products[chocolate] -= product.Value;
                    Report.ChocolateSold += product.Value;
                }
            }
        }

        public  static void DisplayShop(Customer customer)
        {
            bool leave = false;
            while (!leave)
            {
                ShowProducts();


                Console.WriteLine("What do you want to buy?");

                int choice = Convert.ToInt32(Console.ReadLine());
 

                var x = Products.ElementAt(choice-1).Key;

                Console.WriteLine("How many do you wish to buy?");
                int count = Convert.ToInt32(Console.ReadLine());

                customer.MyCart.addProduct(x, count);

                Console.WriteLine("Want anything else? y/n");
                char option= Console.ReadLine()[0];

                if (option == 'n')
                {
                    leave = true;
                    Menu.DisplayMenu(customer);
                }
            }
        }

        public  static void ShowProducts()
        {
            int i = 1;
            foreach(var product in Products)
            {
                Console.WriteLine(i+"."+product.Key.Name + " " + product.Key.Price+"$"+" Quantity: "+ product.Value);
                i++;
            }
        }

       
    }
}
