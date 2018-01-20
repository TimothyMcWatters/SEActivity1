using System;
using System.Collections;

namespace SEActivity1
{
    class Program
    {
        public static GeoObject createGeoObjects(string line)
        {
            string[] token = line.Split(' ');

            if (token[0].Equals("square"))
            {
                Square square = new Square(Double.Parse(token[1]));
                return square;
            }
            else if (token[0].Equals("circle"))
            {
                Circle circle = new Circle(Double.Parse(token[1]));
                return circle;
            }
            else if (token[0].Equals("rectangle"))
            {
                Rectangle rectangle = new Rectangle(Double.Parse(token[1]), Double.Parse(token[2]));
                return rectangle;
            }
            else
            {
                Console.WriteLine("Please check text file to ensure you are using square, circle, or rectangle");
                return null;
            }
        }

        public static void printGeoObjectsDisplay(ArrayList geoObject)
        {
            foreach (GeoObject obj in geoObject)
            {
                obj.display();
            }
        }

        static void Main(string[] args)
        {
            ArrayList geoObjectArrayList = new ArrayList();

            string[] lines = System.IO.File.ReadAllLines(
                @"C:\Users\tim_g\source\repos\ConsoleApp1\ConsoleApp1\Shapes.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                geoObjectArrayList.Add(createGeoObjects(lines[i]));
            }

            printGeoObjectsDisplay(geoObjectArrayList);

            Console.ReadKey();
        }
    }
}
