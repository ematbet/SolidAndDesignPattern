using System;
namespace SolidAndDesignPattern.Liskov.Birds
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Fly!");
        }
    }
}
