namespace Bibles.Infrastructure
{
    using ViewModels;

    public class InstanceLocator
    {
        #region properties
        public MainViewModel Main
        {
            get;
            set;
        }

        #endregion      

        #region
        //Constructor
        public InstanceLocator()
        {
            //nos sirve para ligar la página login a la mainviewmodel
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
