using System;
namespace SolidAndDesignPattern.Liskov.Shape
{
    public class Square : Rectangle
    {
        private float _width;
        private float _height;

        public override float Width
        {

            get { return _width; }
            set
            {
                _width = value;
                _height = value;

            }
        }

        public override float Heigth {

            get { return _height; }
            set
            {
                _height = value;
                _width = value;

            }
        }
    }
}
