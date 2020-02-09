namespace DesignPatternsTraining.DependencyInjection
{
    public interface IEmailService
    {
        void SendMail(string emailAddress, string message);
    }
}
