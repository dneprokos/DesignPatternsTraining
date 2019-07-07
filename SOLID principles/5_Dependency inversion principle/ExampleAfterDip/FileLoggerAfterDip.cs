namespace DesignPatternsTraining.SOLID_principles._5_Dependency_inversion_principle.ExampleAfterDip
{
    public class FileLoggerAfterDip: ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
}
