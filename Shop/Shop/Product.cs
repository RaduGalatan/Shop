using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public enum ProductsType
    { 
        Books,
        Flowers,
        Chocolate
    }

    public class Product
    {
        public Product(ProductsType name)
        {
            switch (name)
            {
                case ProductsType.Books:
                    {
                        Price = 15;
                        Name = ProductsType.Books;
                        break;
                    }
                case ProductsType.Flowers:
                    {
                        Price = 7;
                        Name = ProductsType.Flowers;
                        break;
                    }
                case ProductsType.Chocolate:
                    {
                        Price = 8;
                        Name = ProductsType.Chocolate;
                        break;
                    }
                default:
                    {
                        Price = 0;
                        break;
                    }
            }
        }

        public double Price { get; set; }


        private ProductsType name;

        public ProductsType Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
