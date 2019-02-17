using System;
namespace SolidAndDesignPattern.Liskov.Shape
{
    public class Square : Shape
    {
        public float Edge {get; set; }

        public override float Area()
        {
            return Edge * Edge;
        }
    }
}
