using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForHW._2
{
    class Pen
    {
        public string PenColor { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public int Price { get; set; }
        public void Print()
        {
            Console.WriteLine("\nProduct Id : {0}",Id);
            Console.WriteLine("\nProduct type : {0}",Type);
            Console.WriteLine("\nColor : {0}",PenColor);
            Console.WriteLine("\nPrice : {0}$",Price);
        }
    }
}
