using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForHW._2
{
    class HomeDelivery : Delivery
    {
        private protected int coast = 300;
        private int DeliveryTime { get; set; }
        public HomeDelivery(string address, DateTime date, int time) : base(address, date)
        {
            DeliveryTime = time;
            DeliveryCoast = coast;
            DeliveryDate = date;
        }

        public override void Print()
        {
            Console.WriteLine("Delivery coast = {0}$", DeliveryCoast);
            Console.WriteLine("Delivery date {0}", DeliveryDate);
            Console.WriteLine("Delivery time {0}", DeliveryTime);

        }
    }
}
