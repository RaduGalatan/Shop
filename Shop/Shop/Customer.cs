namespace Shop
{
    public class Customer
    {
        public string Name { get; set; }
        public Cart MyCart { get; set; }
        public Customer(string name)
        {
            Name = name;
            MyCart = new Cart();
        }
    }
}
