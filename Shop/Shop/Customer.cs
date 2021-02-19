using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public  class Customer
    {
        public Customer(string name)
        {
            MyCart = new Cart();
            Name = name;
        }

        private Cart myCart;

        public Cart MyCart
        {
            get { return myCart; }
            set { myCart = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
