using System;
using System.Linq;

namespace SolidAndDesignPattern.Liskov.SumCalculator
{
    public class SumCalculator :Calculator
    {

        public SumCalculator(int[] numbers) 
        : base(numbers)
        {
        }
        public override int Calculate() => _numbers.Sum();
    }
}
