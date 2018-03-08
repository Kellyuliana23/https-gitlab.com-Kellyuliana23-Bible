namespace Bibles.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        //debemos ligar éste objeto login a...
        public LoginViewModel Login
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel ()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
