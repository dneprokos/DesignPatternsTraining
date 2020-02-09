namespace DesignPatternsTraining.DependencyInjection
{
    public class UserLogicMethodInjection
    {
        private GoogleOAuthService _authService;

        public UserLogicMethodInjection()
        {
            _authService = new GoogleOAuthService();
    }

        public void Register(string emailAddress, string password, IEmailService emailService)
        {
            var authResult = _authService.RegisterUser(emailAddress, password);
            emailService.SendMail(emailAddress, authResult.ConfirmationMessage);
        }
    }
}
