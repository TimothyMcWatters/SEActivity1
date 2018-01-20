using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEActivity1
{
    class Square : Rectangle
    {
        private double side;

        public Square(double side) : base(side, side)
        {
            this.side = side;
        }

        public double Side
        {
            get
            {
                return this.side;
            }
            set
            {
                this.side = value;
            }
        }
        public override void display()
        {
            Console.WriteLine("The squares perimeter is: " + calculatePerimeter() +
                " & its area is: " + calculateArea());
        }
    }
}
