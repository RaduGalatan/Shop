using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public class Cart
    {
        private Dictionary<Product, int> productList = new Dictionary<Product, int>();
        private double totalPrice = 0;

        public Dictionary<Product, int> ProductList
        {
            get { return productList; }
            set { productList = value; }
        }
        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        public void showCart()
        {
            if (ProductList.Count == 0)
            {
                Console.WriteLine("Your cart is empty!");
            }
            else
            {
                foreach (var product in ProductList)
                {
                    Console.WriteLine(product.Key.Name + " : " + product.Value + " - " + product.Key.Price + "$/piece");
                }
            }

            Console.WriteLine("Total price is: " + TotalPrice);


        }

        public void addProduct(Product product,int quantity)
        {
            if (Shop.Products[product] < quantity)
            {
                Console.WriteLine("We have only "+ Shop.Products[product]);
            }
            else
            {
                ProductList.Add(product, quantity);
                TotalPrice += product.Price * quantity;
            }

        }
    }
}
