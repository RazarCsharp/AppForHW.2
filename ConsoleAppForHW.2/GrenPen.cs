using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForHW._2
{
    sealed class GrenPen
    {
        private Pen pen;
        private Product product;
        private const string a = "Pen";
        public GrenPen(Pen pen)
        {
            product = new Product(1003);
            this.pen = pen;
            pen.PenColor = "Red";
            pen.Price = 10;
            pen.Id = product.ItemId;
            pen.Type = a;
        }
    }
}
