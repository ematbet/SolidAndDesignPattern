using System;
namespace SolidAndDesignPattern.Liskov
{
    public interface IManaged :IEmployee
    {
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);
    }
}
