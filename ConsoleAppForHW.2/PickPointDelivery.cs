using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForHW._2
{
    internal class PickPointDelivery : Delivery
    {
        private protected int coast = 200;
        private int StorageTime { get; }
        private protected string PickPointAddress;
        public PickPointDelivery(DateTime date) : base(date)
        {
            PickPointAddress = "Street11";
            DeliveryCoast = coast;
            StorageTime = 15;
        }
        public override void Print()
        {
            Console.WriteLine("Delivery coast = {0}$", DeliveryCoast);
            Console.WriteLine("Storage time :{0} day(s)", StorageTime);
            Console.WriteLine("Shop address : {0}", PickPointAddress);
        }
    }
}
