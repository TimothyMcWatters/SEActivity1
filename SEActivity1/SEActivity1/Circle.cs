using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEActivity1
{
    class Circle : GeoObject
    {
        public readonly double PI = 3.14;
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                this.radius = value;
            }
        }

        private double calculateCircumference()
        {
            double circumference = 2 * this.radius * PI;
            return circumference;
        }

        public override double calculatePerimeter()
        {
            double perimeter = calculateCircumference();
            return perimeter;
        }

        public override double calculateArea()
        {
            double area = PI * this.radius * this.radius;
            return area;
        }

        public override void display()
        {
            Console.WriteLine("The circles perimeter is: " + calculatePerimeter() + 
                " & its area is: " + calculateArea());
        }
    }
}
