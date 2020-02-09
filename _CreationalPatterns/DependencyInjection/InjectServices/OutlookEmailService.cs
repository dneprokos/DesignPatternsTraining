namespace DesignPatternsTraining.DependencyInjection
{
    public class OutlookEmailService: IEmailService
    {
        public void SendMail(string emailAddress, string message)
        {
            //Send an email using outlook
        }
    }
}
