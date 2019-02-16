using System;
using System.Linq;

namespace SolidAndDesignPattern.Liskov.SumCalculator
{
    public class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
         : base(numbers)
        {
        }

        public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
