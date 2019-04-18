namespace DesignPatternsTraining.DependencyInjection
{
    public class UserLogicConstructorInjection
    {
        private GoogleOAuthService _authService;
        private IEmailService _emailService;

        public UserLogicConstructorInjection(IEmailService emailService)
        {
            _authService = new GoogleOAuthService();
            _emailService = emailService; 
        }

        public void Register(string emailAddress, string password)
        {
            var authResult = _authService.RegisterUser(emailAddress, password);
            _emailService.SendMail(emailAddress, authResult.ConfirmationMessage);
        }
    }
}
