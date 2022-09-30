using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForHW._2
{
    abstract class Delivery
    {
        public string Address { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int DeliveryCoast { get; set; }
        public Delivery(string address, DateTime deliverydate)
        {
            Address = address;
            DeliveryDate = deliverydate;
        }
        public Delivery(DateTime deliverydate)
        {
            DeliveryDate = deliverydate;
        }
        public abstract void Print();
    }
}
