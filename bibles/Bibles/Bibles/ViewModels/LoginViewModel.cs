namespace Bibles.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;

    //Heredar de la BaseViewModel para evitarme crear tantos eventos
    public class LoginViewModel : BaseViewModel
    {

        #region Attributes
        //Atributo privado con inicial en minúscula
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        #endregion

        //código (video 7)

        #region Properties
        //atributo público con inicial en mayúscula

        public string Email
        {
            // para refrescar la vista y que lo deje en blanco
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }
        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {

            this.IsRemembered = true;
            this.IsEnabled = true;

            this.Email = "kellyuliana23@gmail.com";
            this.Password = "1234";

        }
        #endregion

        #region Commands 
        public ICommand LoginCommand
        {
            get
            {
                //uso el nuget que adicionamos mvvmLightLibs
                return new RelayCommand(Login);
            }
        }


        private async void Login()
        {
            //validar que el usr haya digitado email y pass
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an Email",
                    "Accept");
                //Languages.Error,
                //Languages.EmailValidation,
                //Languages.Accept);
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a Password",
                    "Accept");
                this.Password = string.Empty;
                return;
            }

            this.IsRunning = true;
            this.isEnabled = false;


            //código quemado, se retira después
            if (this.Email != "kellyuliana23@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = false;
                this.isEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or password incorrect",
                    "Accept");
                this.Password = string.Empty;
                return;
            }
            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = string.Empty;
            this.Password = string.Empty;

             //apilar para navegar entre páginas, método asíncrono
            MainViewModel.GetInstance().Bibles = new BiblesViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new BiblesPage());

        }
        
        #endregion
    }
}

