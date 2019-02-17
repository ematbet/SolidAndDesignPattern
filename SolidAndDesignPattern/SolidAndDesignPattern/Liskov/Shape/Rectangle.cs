using System;
namespace SolidAndDesignPattern.Liskov.Shape
{
    public class Rectangle
    {
        public virtual float Width {get; set;}
        public virtual float Heigth { get; set; }

        public float Area {
            get
            {
                return Width * Heigth;
            }
        }
    }
}
