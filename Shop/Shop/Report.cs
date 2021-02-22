using System;
using System.Collections.Generic;
using System.Text;

namespace Shop
{
    public static class Report
    {
        public static int BooksSold { get; set; }
        public static int FlowersSold { get; set; }
        public static int ChocolateSold { get; set; }
        public static int GiftsSold { get; set; }

        public static void ShowReport()
        {
            Console.WriteLine("Books sold: " + BooksSold);
            Console.WriteLine("Flowers sold: " + FlowersSold);
            Console.WriteLine("Chocolate sold: " + ChocolateSold);
            Console.WriteLine("Gifts sold: " + GiftsSold);
        }
    }
}
