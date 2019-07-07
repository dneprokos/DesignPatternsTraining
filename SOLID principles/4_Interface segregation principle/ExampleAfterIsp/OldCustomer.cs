using System;

namespace DesignPatternsTraining.SOLID_principles._4_Interface_segregation_principle.ExampleAfterIsp
{
    public class OldCustomer : IDatabaseIsp
    {
        public void Add()
        {
            Console.WriteLine("Something was added to database");
        }
    }
}
