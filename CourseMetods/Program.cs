using System;
using CourseMetods.Entities;
using CourseMetods.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace CourseMetods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();
            Console.Write("Enter the number os shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle ou circle (r/c):  ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Clue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (c == 'r')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, heigth, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture)); ;
            }
        }
    }
}
