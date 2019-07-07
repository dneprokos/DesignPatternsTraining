namespace DesignPatternsTraining.SOLID_principles._5_Dependency_inversion_principle.ExampleAfterDip
{
    public class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }
}
