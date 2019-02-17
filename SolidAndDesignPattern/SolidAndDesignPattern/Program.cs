using System;
using System.Collections.Generic;
using SolidAndDesignPattern.Liskov;
using SolidAndDesignPattern.Liskov.Birds;

namespace SolidAndDesignPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            IManager accountingVP = new CEO();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Manager();

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();*/

            List<Bird> birds = new List<Bird>();
            Bird duck = new Duck();
            Bird ostrich = new Ostrich();

            birds.Add(duck);
            birds.Add(ostrich);

            birds.ForEach(b => b.Fly());
        }
    }
}
