using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForHW._2
{
    class Order<TDelivery>
        where TDelivery : Delivery
    {
        public TDelivery Delivery { get; set; }
        private ShopDelivery shopDelivery;
        private RedPen redPen;
        private BluePen bluePen;
        private GrenPen grenPen;
        public Guid OrderId;
        public string Description;
        public Order()
        {
            OrderId = Guid.NewGuid();
            Description = GetDescription();
            var pen1 = new Pen();
            redPen = new RedPen(pen1);
            var pen2 = new Pen();
            bluePen = new BluePen(pen2);
            var pen3 = new Pen();
            grenPen = new GrenPen(pen3);
            shopDelivery = new ShopDelivery(new DateTime(2022, 10, 30));
            var pens = new[] { pen1, pen2, pen3 };
            OrderInfo(pens);
        }
        public string GetDescription()
        {
            string description = "description";
            return description;
        }
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);

        }
        public void OrderInfo(Pen[] e)
        {
            Console.WriteLine("\nOrderId : {0}", OrderId);
            Console.WriteLine("\nDescription : {0}", Description);
            shopDelivery.Print();
            Console.WriteLine("Product list :");
            foreach (var item in e)
            {
                Console.WriteLine("\n\t\tProduct:");
                item.Print();
            }
        }
    }
}
