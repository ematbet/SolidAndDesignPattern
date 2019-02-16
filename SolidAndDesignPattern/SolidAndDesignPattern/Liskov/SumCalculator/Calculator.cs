using System;
namespace SolidAndDesignPattern.Liskov.SumCalculator
{
    public abstract class Calculator
    {
        protected readonly int[] _numbers;

        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();

    }
}
