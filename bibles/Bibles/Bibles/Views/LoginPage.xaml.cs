using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bibles.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    
    //CodeBehind que nos marca la contentPage
    //mala práctica ingresar código en CodeBehind
    public partial class LoginPage : ContentPage 
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
	}
}