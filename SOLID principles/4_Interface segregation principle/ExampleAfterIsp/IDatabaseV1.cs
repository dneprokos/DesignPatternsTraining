using DesignPatternsTraining.SOLID_principles._4_Interface_segregation_principle.ExampleAfterIsp;

namespace DesignPatternsTraining.SOLID_principles._4_Interface_segregation_principle.ExampleBeforeIsp
{
    public interface IDatabaseV1 : IDatabaseIsp // Gets the Add method
    {
        void Read();
    }
}
