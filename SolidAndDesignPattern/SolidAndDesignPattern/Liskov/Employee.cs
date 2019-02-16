﻿using System;
namespace SolidAndDesignPattern.Liskov
{
    public class Employee : BaseEmployee , IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public virtual void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }
    }
}
