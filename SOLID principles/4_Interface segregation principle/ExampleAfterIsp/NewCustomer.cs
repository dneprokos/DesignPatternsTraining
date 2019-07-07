using DesignPatternsTraining.SOLID_principles._4_Interface_segregation_principle.ExampleBeforeIsp;
using System;

namespace DesignPatternsTraining.SOLID_principles._4_Interface_segregation_principle.ExampleAfterIsp
{
    public class NewCustomer : IDatabaseV1
    {
        public void Add()
        {
            Console.WriteLine("Something was added to database");
        }

        public void Read()
        {
            Console.WriteLine("Starting to read from DB");
        }
    }
}
