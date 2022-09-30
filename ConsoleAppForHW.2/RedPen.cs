using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForHW._2
{
    sealed class RedPen
    {
        private Pen pen;
        private Product product;
        private const string a = "Pen";

        public RedPen(Pen pen)
        {
            product = new Product(1001);
            this.pen = pen;
            pen.PenColor = "Red";
            pen.Price = 20;
            pen.Id = product.ItemId;
            pen.Type = a;
        }
    }
}
