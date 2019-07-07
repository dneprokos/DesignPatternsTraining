namespace DesignPatternsTraining.SOLID_principles._5_Dependency_inversion_principle.ExampleBeforeDip
{
    public class FileLoggerBeforeDip
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
}
