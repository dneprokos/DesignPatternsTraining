namespace DesignPatternsTraining.DependencyInjection
{
    public class UserLogicSetterInjection
    {
        private GoogleOAuthService _authService;
        private IEmailService _emailService;

        public IEmailService EmailService
        {
            get
            {
                return _emailService;
            }
            set
            {
                _emailService = value;
            }
        }

        public UserLogicSetterInjection()
        {
            _authService = new GoogleOAuthService();
        }

        public void Register(string emailAddress, string password)
        {
            var authResult = _authService.RegisterUser(emailAddress, password);
            _emailService.SendMail(emailAddress, authResult.ConfirmationMessage);
        }
    }
}
