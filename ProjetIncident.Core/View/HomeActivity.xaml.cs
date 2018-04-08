using System;
using ProjetIncident.Core.ViewModel;
using Xamarin.Forms;

namespace ProjetIncident.Core.View
{
    public partial class HomeActivity : ContentPage
    {
        public HomeActivity()
        {
			var vm = new LoginViewModel();
			this.BindingContext = vm;
			vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
		

			Email.Completed += (object sender, EventArgs e) =>
			{
				Password.Focus();
			};

			Password.Completed += (object sender, EventArgs e) =>
			{
				vm.SubmitCommand.Execute(null);
			};
			InitializeComponent();
        }

		

		
    }
}
