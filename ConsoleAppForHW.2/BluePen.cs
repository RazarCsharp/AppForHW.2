using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForHW._2
{
    sealed class BluePen
    {
        private Pen pen;
        private Product product;
        private const string a = "Pen";
        public BluePen(Pen pen)
        {
            product = new Product(1002);
            this.pen = pen;
            pen.PenColor = "Red";
            pen.Price = 30;
            pen.Id = product.ItemId;
            pen.Type = a;
        }
    }
}
