using System;
using System.Collections.Generic;

namespace DesignPatternsTraining._BehavioralPatterns.VisitorDesignPattern.Employees
{
    /// <summary>
    /// The Object Structure class, which is a collection of Concrete Elements.  This could be implemented using another pattern such as Composite.
    /// </summary>
    public class Employees
    {
        private List<Employee> _employees = new List<Employee>();

        public void Attach(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Employee e in _employees)
            {
                e.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
