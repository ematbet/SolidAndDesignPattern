using System;
namespace SolidAndDesignPattern.Liskov
{
    public interface IManager :IEmployee
    {
        void GeneratePerformanceReview();
    }
}
