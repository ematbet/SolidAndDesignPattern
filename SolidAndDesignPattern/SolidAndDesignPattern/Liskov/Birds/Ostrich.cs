using System;
namespace SolidAndDesignPattern.Liskov.Birds
{
    public class Ostrich : Bird
    {
        public override void Fly()
        {
            throw new InvalidOperationException("I Can't fly!");
        }
    }
}
