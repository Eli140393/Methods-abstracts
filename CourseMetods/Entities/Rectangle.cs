using System;
using System.Collections.Generic;
using System.Text;
using CourseMetods.Entities.Enums;
namespace CourseMetods.Entities
{
    class Rectangle : Shape
    {

        public double Width { get; set; }
        public double Heigth { get; set; }

        public Rectangle(double width, double heigth, Color color)
            :base(color)
        {
            Width = width;
            Heigth = heigth;
        }
        public override double Area()
        {
            return Width * Heigth;
        }
    }
}
