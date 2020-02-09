using DesignPatternsTraining._BehavioralPatterns.VisitorDesignPattern.Employees;
using System;

namespace DesignPatternsTraining._BehavioralPatterns.VisitorDesignPattern.ConcreateVisitors
{
    /// <summary>
    /// A Concrete Visitor class.
    /// </summary>
    public class IncomeVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // We've had a great year, so 10% pay raises for everyone!
            employee.AnnualSalary *= 1.10;
            Console.WriteLine("{0} {1}'s new income: {2:C}", employee.GetType().Name, employee.Name, employee.AnnualSalary);
        }
    }
}
