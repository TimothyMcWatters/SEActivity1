using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEActivity1
{
    class Rectangle : GeoObject
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = value;
            }
        }

        public override double calculateArea()
        {
            double area = height * width;
            return area;
        }

        public override double calculatePerimeter()
        {
            double perimeter = (height + width) * 2;
            return perimeter;
        }

        public override void display()
        {
            Console.WriteLine("The rectangles perimeter is: " + calculatePerimeter() +
                " & its area is: " + calculateArea());
        }
    }
}
