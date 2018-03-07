namespace Bibles.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        //debemos ligar éste objeto login a la 
        public LoginViewModel login
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel ()
        {
            this.login = new LoginViewModel();
        }
        #endregion
    }
}
