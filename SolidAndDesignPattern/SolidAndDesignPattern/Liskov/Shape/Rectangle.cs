using System;
namespace SolidAndDesignPattern.Liskov.Shape
{
    public class Rectangle : Shape
    {
        public float Width {get; set;}
        public float Heigth { get; set; }



        public override float Area()
        {
            return Width * Heigth;
        }
    }
}
