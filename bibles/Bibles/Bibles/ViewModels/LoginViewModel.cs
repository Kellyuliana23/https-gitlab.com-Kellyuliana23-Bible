namespace Bibles.ViewModels
{
    using System.Windows.Input;
   

    public class LoginViewModel
    {
        //después insertaremos el código (video 7)
     
        #region Properties
        public string Email
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get;
            set;
        }

        public bool IsRemembered
        {
            get;
            set;
        }
        #endregion

        #region Constructors 
        public LoginViewModel()
        {
            this.IsRemembered = true;
        }
        #endregion

        #region Commands 
        public ICommand LoginCommand
        {
            get;
            set;
        }
        #endregion

    }
}

