namespace Bibles.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public BiblesViewModel Bibles
        {
            get;
            set;
        }

        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        //hacer un llamado de la MainViewModel desde cualquier clase
        //sin necesidad de tener que instanciar otra MainViewModel
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
            return new MainViewModel();
            }
            return instance;
        }
        #endregion


    }
}
