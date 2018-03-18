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

        public BibleViewModel Bible
        {
            get;
            set;
        }

        public BookViewModel Book
        {
            get;
            set;
        }


        #endregion


        #region Properties
        public string SelectedModule
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



        //hacer un llamado de la MainViewModel desde cualquier clase
        //sin necesidad de tener que instanciar otra MainViewModel
        #region Singleton
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
