using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjetIncident.Core.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged;
        private string email;

        public string Email
        {
            get { return email; }
            set 
            {
				email = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
			set
			{
                password = value;
				PropertyChanged(this, new PropertyChangedEventArgs("Pass123"));
			}
        }

		
		
		public void OnSubmit()
		{
			if (email != "blabla@bla.com" || password != "pass123")
			{
				DisplayInvalidLoginPrompt();
			}
		}
	}
}
