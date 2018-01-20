using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEActivity1
{
    abstract class GeoObject
    {
        public abstract double calculateArea();

        public abstract double calculatePerimeter();

        public virtual void display()
        {
            Console.WriteLine("Nothing to display.");
        }

    }
}
