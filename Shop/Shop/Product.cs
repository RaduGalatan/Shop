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
        public double Price { get; set; }
        public ProductsType Name { get; set; }
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
    }
}
