namespace DesignPatternsTraining.DependencyInjection
{
    public class GoogleEmailService: IEmailService
    {
        public void SendMail(string emailAddress, string message)
        {
            //Send an email using google
        }
    }
}