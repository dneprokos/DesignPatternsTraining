namespace DesignPatternsTraining.DependencyInjection
{
    public class UserLogicInitial
    {
        private GoogleOAuthService _authService;
        private IEmailService _emailService;

        public UserLogicInitial()
        {
            _authService = new GoogleOAuthService();
            _emailService = new OutlookEmailService();
            // Or _emailService = new GoogleEmailService();

            // or Google;
        }

        public void Register(string emailAddress, string password)
        {
            var authResult = _authService.RegisterUser(emailAddress, password);
            _emailService.SendMail(emailAddress, authResult.ConfirmationMessage);
        }
    }
}
