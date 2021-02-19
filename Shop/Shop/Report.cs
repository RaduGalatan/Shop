using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public static class Report
    {

        private static int booksSold;

        public static int BooksSold
        {
            get { return booksSold; }
            set {  booksSold= value; }
        }

        private static int flowersSold;

        public static int FlowersSold
        {
            get { return flowersSold; }
            set { flowersSold = value; }
        }

        private static int chocolateSold;

        public static int ChocolateSold
        {
            get { return chocolateSold; }
            set { chocolateSold = value; }
        }

        private static int giftsSold;

        public static int GiftsSold
        {
            get { return giftsSold; }
            set { giftsSold = value; }
        }


        public static void ShowReport()
        {
            Console.WriteLine("Books sold: " + BooksSold);
            Console.WriteLine("Flowers sold: " + FlowersSold);
            Console.WriteLine("Chocolate sold: " + ChocolateSold);
            Console.WriteLine("Gifts sold: " + GiftsSold);
        }


    }
}
