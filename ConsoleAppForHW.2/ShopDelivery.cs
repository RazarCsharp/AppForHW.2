using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForHW._2
{
    internal class ShopDelivery : Delivery
    {
        private int coast = 100;
        private int StorageTime { get; }
        private string ShopAddress;
        public ShopDelivery(DateTime date) : base(date)
        {
            ShopAddress = "Street22";
            DeliveryCoast = coast;
            StorageTime = 30;
        }
        public override void Print()
        {
            Console.WriteLine("\nDelivery coast = {0}$", DeliveryCoast);
            Console.WriteLine("\nStorage time :{0} day(s)", StorageTime);
            Console.WriteLine("\nShop address : {0}", ShopAddress);
            Console.WriteLine("\nDelivery date : {0}",DeliveryDate);
        }
    }
}
