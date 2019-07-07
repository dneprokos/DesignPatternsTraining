namespace DesignPatternsTraining.SOLID_principles._5_Dependency_inversion_principle.ExampleAfterDip
{
    public class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }
}
