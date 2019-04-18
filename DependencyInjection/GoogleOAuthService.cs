namespace DesignPatternsTraining.DependencyInjection
{
    public class GoogleOAuthService
    {
        public string ConfirmationMessage;
        public GoogleOAuthService RegisterUser(string emailAddress, string password)
        {
            return this;
        }
    }
}